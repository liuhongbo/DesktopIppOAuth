using System;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Framework;
using System.Threading.Tasks;
using System.Threading;
#if NET40
using System.Web.Http.SelfHost;
#else
using Microsoft.Owin.Hosting;
#endif

namespace DesktopIppOAuth
{
    public class OAuthConnector
    {

        public delegate void IppOAuthResultHandler(string accessToken, string accessTokenSecret, string realmId, string dataSource);
        public event IppOAuthResultHandler IppOAuthResultEvent;
#if NET40
        HttpSelfHostServer _webApp = null;
#else
        IDisposable _webApp = null;
#endif
        private string _defaultBaseAddress = @"http://localhost:65521/";
        private IToken _requestToken;

        public static OAuthConnector Current { get; set; }

        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string BaseAddress { get; set; }
        public string RedirectUrl { get; set; }
        public string SuccessView { get; set; }

        // URLs for the OAuth provider
        private string _baseAuthUrl = "https://workplace.intuit.com/Connect/Begin";
        private string _requestTokenUrl = "https://oauth.intuit.com/oauth/v1/get_request_token";
        private string _oauthUrl = "https://oauth.intuit.com/oauth/v1";
        private string _accessTokenUrl = "https://oauth.intuit.com/oauth/v1/get_access_token";

        public string RealmId { get; set; }
        public string DataSource { get; set; }
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }

        
        public void Connect(string consumerKey, string consumerSecret)
        {
            Connect(consumerKey, consumerSecret, _defaultBaseAddress);
        }

        public void Connect(string consumerKey, string consumerSecret, string baseAddress)
        {
            Connect(consumerKey, consumerSecret, _defaultBaseAddress, null);
        }

        public void Connect(string consumerKey, string consumerSecret, string baseAddress, string redirectUrl)
        {
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            BaseAddress = baseAddress?? _defaultBaseAddress;
            RedirectUrl = redirectUrl;

            if (Current != null)
            {
                Current.Clean();
            }
            Current = this;

#if NET40
            _webApp = new HttpSelfHostServer(Startup.Configuration(BaseAddress));
            _webApp.OpenAsync().Wait();
            
#else
            _webApp = WebApp.Start<Startup>(url: BaseAddress);
#endif
            IOAuthSession session = CreateSession();
            IToken theToken = session.GetRequestToken();

            _requestToken = theToken;

            // Redirect user to Intuit for Auth
            string token = theToken.Token;
            string secret = theToken.TokenSecret; 
            System.Diagnostics.Process.Start(
                _baseAuthUrl
                    + "?oauth_token=" + token
                    + "&oauth_callback=" + UriUtility.UrlEncode(BaseAddress + "api/oauth/")
                    );

        }


        public void OAuthCallback(string verifier, string realmId, string dataSource)
        {

            RealmId = realmId;
            DataSource = dataSource;

            // Retrieve the request token saved earlier
            IToken theToken = _requestToken;

            // Use the request token and auth verifier to get an access token
            IOAuthSession clientSession = CreateSession();
            try
            {
                IToken accessToken = clientSession.ExchangeRequestTokenForAccessToken(theToken, verifier);
                AccessToken = accessToken.Token;
                AccessTokenSecret = accessToken.TokenSecret;

                IppOAuthResultEvent.Invoke(AccessToken, AccessTokenSecret, RealmId, DataSource);
#if NET40
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate (object state)
                {
                    Thread.Sleep(2000);
                    Clean();
                }));
#else
                Task.Run(() => {
                    Task.Delay(2000).Wait();
                    Clean();
                });
#endif                
            }
            catch (Exception ex)
            {
                Clean();
                throw ex;
            }
        }

        public void Clean()
        {
            if (_webApp != null)
            {
#if NET40
                _webApp.CloseAsync().Wait();
#endif
                _webApp.Dispose();
                _webApp = null;
            }
            Current = null;
        }

        private IOAuthSession CreateSession()
        {
            OAuthConsumerContext consumerContext = new OAuthConsumerContext
            {
                ConsumerKey = this.ConsumerKey,
                ConsumerSecret = this.ConsumerSecret,
                SignatureMethod = SignatureMethod.HmacSha1
            };
            return new OAuthSession(consumerContext,
                    _requestTokenUrl,
                    _oauthUrl,
                    _accessTokenUrl);
        }


    }
}
