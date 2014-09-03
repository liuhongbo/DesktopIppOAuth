using System.Web.Http;

namespace DesktopIppOAuth
{
    public class OAuthController : ApiController
    {
        public delegate void OAuthCallbackHandler(string verifier, string realmId, string dataSource);

        public event OAuthCallbackHandler OAuthCallbackEvent;

        public OAuthController()
        {
            this.OAuthCallbackEvent += OAuthConnector.Current.OAuthCallback;
        }

        public string Get(string oauth_verifier, string realmId, string dataSource)
        {
            OAuthCallbackEvent.Invoke(oauth_verifier, realmId, dataSource);
            return "OK";
        }
    }
}
