using System;
using System.Windows.Forms;
using DesktopIppOAuth;

namespace DesktopIppOAuthSample
{
    public partial class FormMain : Form
    {        
        // OAuth consumer key and secret from OAuth provider, replace with your own!!
        private string consumerKey = "qyprdQwUSEPUBvlHGyLFzLnvOv0hMI";
        private string consumerSecret = "ofnQjwhQk0G1UMN8uYOA8tu142DIAJTJtLrsjqsL";
        private DesktopIppOAuth.OAuthConnector _connector;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {          
            textBoxConsumerKey.Text = consumerKey;
            textBoxConsumerKeySecret.Text = consumerSecret;
            _connector = new OAuthConnector();
            _connector.IppOAuthResultEvent += _connector_IppOAuthResultEvent;

        }

        void _connector_IppOAuthResultEvent(string accessToken, string accessTokenSecret, string realmId, string dataSource)
        {
            SafeInvokeHelper.Invoke(textBoxRealmId, "set_Text", realmId);
            SafeInvokeHelper.Invoke(textBoxDataSource, "set_Text", dataSource);
            SafeInvokeHelper.Invoke(textBoxAccessToken, "set_Text", accessToken);
            SafeInvokeHelper.Invoke(textBoxAccessTokenSecret, "set_Text", accessTokenSecret);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _connector.Clean();
        }      

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            consumerKey = textBoxConsumerKey.Text;
            consumerSecret = textBoxConsumerKeySecret.Text;

            _connector.Connect(consumerKey, consumerSecret);
            
        }       
    }
}
