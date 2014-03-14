using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevDefined.OAuth.Consumer;
using DevDefined.OAuth.Framework;
using Microsoft.Owin.Hosting;

namespace DesktopIppOAuth
{
    public class OAuthConnector
    {

        public delegate void IppOAuthResultHandler(string accessToken, string accessTokenSecret, string realmId, string dataSource);
        public event IppOAuthResultHandler IppOAuthResultEvent;

        IDisposable _webApp = null;
        private string _defaultBaseAddress = @"http://localhost:65521/";
        private IToken _requestToken;

        public static OAuthConnector Current { get; set; }

        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string BaseAddress { get; set; }

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
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            BaseAddress = baseAddress;

            Current = this;

            _webApp = WebApp.Start<Startup>(url: BaseAddress);

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

                _webApp.Dispose();
                _webApp = null;
            }
            catch (Exception ex)
            {
                _webApp.Dispose();
                _webApp = null;
                throw ex;
            }
        }

        public void Clean()
        {
            if (_webApp != null)
            {
                _webApp.Dispose();
                _webApp = null;
            }
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
