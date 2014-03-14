DesktopIppOAuth
==============

A Libaray for desktop application to get the OAuth Access Token of Intuit Partner Platform Rest APIs.  It uses a OWIN selfhost web api 2.0 to receive the OAuth callback so that you don't need to implment a separated web site just for receiving the tokens.


QuickStart
----------

* Install Package from Nuget

    Install-Package DesktopIppOAuth

* Use it like this

        // OAuth consumer key and secret from OAuth provider
        private string consumerKey = "your consumer key";
        private string consumerSecret = "you consumer secret";
        private DesktopIppOAuth.OAuthConnector _connector;


        _connector = new OAuthConnector();
        _connector.IppOAuthResultEvent += _connector_IppOAuthResultEvent;

	_connector.Connect(consumerKey, consumerSecret);

    
        void _connector_IppOAuthResultEvent(string accessToken, string accessTokenSecret, string realmId, string dataSource)
        {
            //save the token information somewher for later API call.
        }

Why DesktopIppOAuth
-------------------



