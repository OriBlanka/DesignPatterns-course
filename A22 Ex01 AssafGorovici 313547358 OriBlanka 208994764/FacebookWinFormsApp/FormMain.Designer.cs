namespace BasicFacebookFeatures
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_MainTab = new System.Windows.Forms.TabPage();
            this.m_FetchEventsTab = new System.Windows.Forms.TabPage();
            this.m_MutualLikedPagesTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.m_MainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(26, 27);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(477, 55);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(26, 96);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(477, 55);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.m_MainTab);
            this.tabControl1.Controls.Add(this.m_FetchEventsTab);
            this.tabControl1.Controls.Add(this.m_MutualLikedPagesTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2231, 1397);
            this.tabControl1.TabIndex = 53;
            // 
            // m_MainTab
            // 
            this.m_MainTab.Controls.Add(this.buttonLogout);
            this.m_MainTab.Controls.Add(this.buttonLogin);
            this.m_MainTab.Location = new System.Drawing.Point(10, 48);
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_MainTab.Size = new System.Drawing.Size(2211, 1339);
            this.m_MainTab.TabIndex = 0;
            this.m_MainTab.Text = "Main";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // m_FetchEventsTab
            // 
            this.m_FetchEventsTab.Location = new System.Drawing.Point(10, 48);
            this.m_FetchEventsTab.Name = "m_FetchEventsTab";
            this.m_FetchEventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FetchEventsTab.Size = new System.Drawing.Size(2211, 1339);
            this.m_FetchEventsTab.TabIndex = 1;
            this.m_FetchEventsTab.Text = "My Events";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Location = new System.Drawing.Point(10, 48);
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.Size = new System.Drawing.Size(2211, 1339);
            this.m_MutualLikedPagesTab.TabIndex = 2;
            this.m_MutualLikedPagesTab.Text = "Mutual Liked Pages";
            this.m_MutualLikedPagesTab.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2241, 1421);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.m_MainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_MainTab;
        private System.Windows.Forms.TabPage m_FetchEventsTab;
        private System.Windows.Forms.TabPage m_MutualLikedPagesTab;
    }
}

