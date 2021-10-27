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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.m_MainTab = new System.Windows.Forms.TabPage();
            this.m_FetchEventsTab = new System.Windows.Forms.TabPage();
            this.m_MutualLikedPagesTab = new System.Windows.Forms.TabPage();
            this.m_UserProfilePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.m_MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(15, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(169, 51);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1777, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(169, 51);
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
            this.tabControl1.Font = new System.Drawing.Font("Miriam", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 223);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1936, 1095);
            this.tabControl1.TabIndex = 53;
            // 
            // m_MainTab
            // 
            this.m_MainTab.Controls.Add(this.pictureBox4);
            this.m_MainTab.Controls.Add(this.pictureBox3);
            this.m_MainTab.Controls.Add(this.pictureBox2);
            this.m_MainTab.Controls.Add(this.pictureBox1);
            this.m_MainTab.Controls.Add(this.button5);
            this.m_MainTab.Controls.Add(this.button4);
            this.m_MainTab.Controls.Add(this.listBox5);
            this.m_MainTab.Controls.Add(this.listBox4);
            this.m_MainTab.Controls.Add(this.listBox3);
            this.m_MainTab.Controls.Add(this.button3);
            this.m_MainTab.Controls.Add(this.listBox2);
            this.m_MainTab.Controls.Add(this.button2);
            this.m_MainTab.Controls.Add(this.button1);
            this.m_MainTab.Controls.Add(this.listBox1);
            this.m_MainTab.Location = new System.Drawing.Point(10, 49);
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_MainTab.Size = new System.Drawing.Size(1916, 1036);
            this.m_MainTab.TabIndex = 0;
            this.m_MainTab.Text = "Main";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // m_FetchEventsTab
            // 
            this.m_FetchEventsTab.Location = new System.Drawing.Point(10, 49);
            this.m_FetchEventsTab.Name = "m_FetchEventsTab";
            this.m_FetchEventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FetchEventsTab.Size = new System.Drawing.Size(1916, 1036);
            this.m_FetchEventsTab.TabIndex = 1;
            this.m_FetchEventsTab.Text = "My Events";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Location = new System.Drawing.Point(10, 49);
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.Size = new System.Drawing.Size(1916, 1036);
            this.m_MutualLikedPagesTab.TabIndex = 2;
            this.m_MutualLikedPagesTab.Text = "Mutual Liked Pages";
            this.m_MutualLikedPagesTab.UseVisualStyleBackColor = true;
            // 
            // m_UserProfilePicture
            // 
            this.m_UserProfilePicture.Image = global::BasicFacebookFeatures.Properties.Resources.FacebookLogo;
            this.m_UserProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("m_UserProfilePicture.InitialImage")));
            this.m_UserProfilePicture.Location = new System.Drawing.Point(819, 15);
            this.m_UserProfilePicture.Name = "m_UserProfilePicture";
            this.m_UserProfilePicture.Size = new System.Drawing.Size(184, 202);
            this.m_UserProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_UserProfilePicture.TabIndex = 54;
            this.m_UserProfilePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1028, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(470, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1315, 190);
            this.listBox1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 108);
            this.button1.TabIndex = 57;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 85);
            this.button2.TabIndex = 58;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(52, 455);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(673, 128);
            this.listBox2.TabIndex = 59;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1074, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 102);
            this.button3.TabIndex = 60;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 31;
            this.listBox3.Location = new System.Drawing.Point(1063, 455);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(604, 128);
            this.listBox3.TabIndex = 61;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 31;
            this.listBox4.Location = new System.Drawing.Point(52, 837);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(673, 128);
            this.listBox4.TabIndex = 62;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 31;
            this.listBox5.Location = new System.Drawing.Point(1045, 820);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(673, 128);
            this.listBox5.TabIndex = 63;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(52, 709);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 85);
            this.button4.TabIndex = 64;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1063, 699);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 85);
            this.button5.TabIndex = 65;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(385, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 123);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1405, 312);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 123);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(385, 671);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 123);
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1405, 691);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(216, 123);
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1970, 1423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_UserProfilePicture);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1998, 1502);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.m_MainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage m_MainTab;
        private System.Windows.Forms.TabPage m_FetchEventsTab;
        private System.Windows.Forms.TabPage m_MutualLikedPagesTab;
        private System.Windows.Forms.PictureBox m_UserProfilePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

