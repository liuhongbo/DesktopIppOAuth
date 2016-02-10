using System;
using System.Net;
using System.Net.Http;
using System.Text;
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

        public HttpResponseMessage Get(string oauth_verifier, string realmId, string dataSource)
        {
            OAuthCallbackEvent.Invoke(oauth_verifier, realmId, dataSource);
            if (string.IsNullOrEmpty(OAuthConnector.Current.RedirectUrl))
            {
                var response = Request.CreateResponse(HttpStatusCode.OK, "text/html");
                string content;
                if (string.IsNullOrEmpty(OAuthConnector.Current.SuccessView))
                {
                    content =
@"<!DOCTYPE html>
<html>
<head>
<title>DesktopIppOAuth</title>
</head>
<body>
<h1 style='color:green;'>Success!</h1>
<p>You have authorized the application to connect to your QuickBooks online.</p>
</body>
</html>";
                }
                else {
                    content = OAuthConnector.Current.SuccessView;
                }              
                response.Content = new StringContent(content, Encoding.UTF8, "text/html");
                return response;
            }
            else {
                var response = Request.CreateResponse(HttpStatusCode.Moved);
                response.Headers.Location = new Uri(OAuthConnector.Current.RedirectUrl);
                return response;
            }
            
        }
    }
}
