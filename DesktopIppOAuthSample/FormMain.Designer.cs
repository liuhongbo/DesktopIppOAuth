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
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(127, 123);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(207, 42);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consumer Key";
            // 
            // textBoxConsumerKey
            // 
            this.textBoxConsumerKey.Location = new System.Drawing.Point(127, 38);
            this.textBoxConsumerKey.Name = "textBoxConsumerKey";
            this.textBoxConsumerKey.Size = new System.Drawing.Size(284, 20);
            this.textBoxConsumerKey.TabIndex = 2;
            // 
            // textBoxConsumerKeySecret
            // 
            this.textBoxConsumerKeySecret.Location = new System.Drawing.Point(127, 70);
            this.textBoxConsumerKeySecret.Name = "textBoxConsumerKeySecret";
            this.textBoxConsumerKeySecret.Size = new System.Drawing.Size(284, 20);
            this.textBoxConsumerKeySecret.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumer Key Secret";
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Location = new System.Drawing.Point(127, 230);
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(284, 20);
            this.textBoxDataSource.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Source";
            // 
            // textBoxRealmId
            // 
            this.textBoxRealmId.Location = new System.Drawing.Point(127, 198);
            this.textBoxRealmId.Name = "textBoxRealmId";
            this.textBoxRealmId.Size = new System.Drawing.Size(284, 20);
            this.textBoxRealmId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Realm Id";
            // 
            // textBoxAccessToken
            // 
            this.textBoxAccessToken.Location = new System.Drawing.Point(127, 260);
            this.textBoxAccessToken.Name = "textBoxAccessToken";
            this.textBoxAccessToken.Size = new System.Drawing.Size(423, 20);
            this.textBoxAccessToken.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Access Token";
            // 
            // textBoxAccessTokenSecret
            // 
            this.textBoxAccessTokenSecret.Location = new System.Drawing.Point(127, 288);
            this.textBoxAccessTokenSecret.Name = "textBoxAccessTokenSecret";
            this.textBoxAccessTokenSecret.Size = new System.Drawing.Size(423, 20);
            this.textBoxAccessTokenSecret.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Access Token Secret";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 357);
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
    }
}

