using System.Web.Http;
using System.Web.Http.SelfHost;

namespace DesktopIppOAuth
{
    //http://www.asp.net/web-api
    public class Startup
    {
        public static HttpSelfHostConfiguration Configuration(string url)
        {
            var config = new HttpSelfHostConfiguration(url);

            config.Routes.MapHttpRoute(
                "DefaultApi", "api/{controller}/{id}",
                new { id = RouteParameter.Optional });

            return config;
        }
    }
}
