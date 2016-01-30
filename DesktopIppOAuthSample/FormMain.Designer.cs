namespace DesktopIppOAuthSample
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConsumerKey = new System.Windows.Forms.TextBox();
            this.textBoxConsumerKeySecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRealmId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccessToken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAccessTokenSecret = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRedirectUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(190, 207);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(310, 65);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consumer Key";
            // 
            // textBoxConsumerKey
            // 
            this.textBoxConsumerKey.Location = new System.Drawing.Point(190, 58);
            this.textBoxConsumerKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxConsumerKey.Name = "textBoxConsumerKey";
            this.textBoxConsumerKey.Size = new System.Drawing.Size(424, 26);
            this.textBoxConsumerKey.TabIndex = 2;
            // 
            // textBoxConsumerKeySecret
            // 
            this.textBoxConsumerKeySecret.Location = new System.Drawing.Point(190, 108);
            this.textBoxConsumerKeySecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxConsumerKeySecret.Name = "textBoxConsumerKeySecret";
            this.textBoxConsumerKeySecret.Size = new System.Drawing.Size(424, 26);
            this.textBoxConsumerKeySecret.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumer Key Secret";
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Location = new System.Drawing.Point(190, 354);
            this.textBoxDataSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(424, 26);
            this.textBoxDataSource.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Source";
            // 
            // textBoxRealmId
            // 
            this.textBoxRealmId.Location = new System.Drawing.Point(190, 305);
            this.textBoxRealmId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRealmId.Name = "textBoxRealmId";
            this.textBoxRealmId.Size = new System.Drawing.Size(424, 26);
            this.textBoxRealmId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Realm Id";
            // 
            // textBoxAccessToken
            // 
            this.textBoxAccessToken.Location = new System.Drawing.Point(190, 400);
            this.textBoxAccessToken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAccessToken.Name = "textBoxAccessToken";
            this.textBoxAccessToken.Size = new System.Drawing.Size(632, 26);
            this.textBoxAccessToken.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Access Token";
            // 
            // textBoxAccessTokenSecret
            // 
            this.textBoxAccessTokenSecret.Location = new System.Drawing.Point(190, 443);
            this.textBoxAccessTokenSecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAccessTokenSecret.Name = "textBoxAccessTokenSecret";
            this.textBoxAccessTokenSecret.Size = new System.Drawing.Size(632, 26);
            this.textBoxAccessTokenSecret.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 446);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Access Token Secret";
            // 
            // textBoxRedirectUrl
            // 
            this.textBoxRedirectUrl.Location = new System.Drawing.Point(192, 155);
            this.textBoxRedirectUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRedirectUrl.Name = "textBoxRedirectUrl";
            this.textBoxRedirectUrl.Size = new System.Drawing.Size(424, 26);
            this.textBoxRedirectUrl.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Redirect Url";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 549);
            this.Controls.Add(this.textBoxRedirectUrl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAccessTokenSecret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAccessToken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDataSource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRealmId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxConsumerKeySecret);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConsumerKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Desktop Ipp OAuth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConsumerKey;
        private System.Windows.Forms.TextBox textBoxConsumerKeySecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRealmId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAccessToken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAccessTokenSecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRedirectUrl;
        private System.Windows.Forms.Label label7;
    }
}

