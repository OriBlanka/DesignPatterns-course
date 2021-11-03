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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.m_FetchEventsTab = new System.Windows.Forms.TabPage();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.m_MutualLikedPagesTab = new System.Windows.Forms.TabPage();
            this.m_UserProfilePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_HelloUserLabel = new System.Windows.Forms.Label();
            this.comboBoxEventsStatus = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.m_MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_FetchEventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(17, 16);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(501, 59);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(2348, 20);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(193, 55);
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
            this.tabControl1.Location = new System.Drawing.Point(17, 238);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2540, 1304);
            this.tabControl1.TabIndex = 53;
            // 
            // m_MainTab
            // 
            this.m_MainTab.Controls.Add(this.linkLabel1);
            this.m_MainTab.Controls.Add(this.pictureBox5);
            this.m_MainTab.Controls.Add(this.listBox1);
            this.m_MainTab.Controls.Add(this.button1);
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
            this.m_MainTab.Controls.Add(this.buttonFetchPosts);
            this.m_MainTab.Controls.Add(this.listBoxPosts);
            this.m_MainTab.Location = new System.Drawing.Point(10, 51);
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_MainTab.Size = new System.Drawing.Size(2520, 1243);
            this.m_MainTab.TabIndex = 0;
            this.m_MainTab.Text = "Main";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(597, 1034);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(152, 35);
            this.linkLabel1.TabIndex = 73;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(2151, 334);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(247, 131);
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(1760, 486);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(690, 136);
            this.listBox1.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1772, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 109);
            this.button1.TabIndex = 70;
            this.button1.Text = "Friends";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(2172, 757);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(247, 131);
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(440, 717);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 131);
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1301, 743);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 131);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(440, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 131);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1781, 765);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 91);
            this.button5.TabIndex = 65;
            this.button5.Text = "Favorite Teams";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(59, 758);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 91);
            this.button4.TabIndex = 64;
            this.button4.Text = "Albums";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 33;
            this.listBox5.Location = new System.Drawing.Point(1760, 895);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(690, 136);
            this.listBox5.TabIndex = 63;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 33;
            this.listBox4.Location = new System.Drawing.Point(59, 895);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(690, 136);
            this.listBox4.TabIndex = 62;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 33;
            this.listBox3.Location = new System.Drawing.Point(910, 895);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(690, 136);
            this.listBox3.TabIndex = 61;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 747);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 109);
            this.button3.TabIndex = 60;
            this.button3.Text = "Groups";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 33;
            this.listBox2.Location = new System.Drawing.Point(59, 486);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(690, 136);
            this.listBox2.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 91);
            this.button2.TabIndex = 58;
            this.button2.Text = "Liked Pages";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(213, 108);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(287, 115);
            this.buttonFetchPosts.TabIndex = 57;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 33;
            this.listBoxPosts.Location = new System.Drawing.Point(621, 67);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(1502, 202);
            this.listBoxPosts.TabIndex = 56;
            // 
            // m_FetchEventsTab
            // 
            this.m_FetchEventsTab.Controls.Add(this.comboBoxEventsStatus);
            this.m_FetchEventsTab.Controls.Add(this.buttonFetchEvents);
            this.m_FetchEventsTab.Controls.Add(this.dataGridViewEvents);
            this.m_FetchEventsTab.Location = new System.Drawing.Point(10, 51);
            this.m_FetchEventsTab.Name = "m_FetchEventsTab";
            this.m_FetchEventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FetchEventsTab.Size = new System.Drawing.Size(2520, 1243);
            this.m_FetchEventsTab.TabIndex = 1;
            this.m_FetchEventsTab.Text = "My Events";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(509, 7);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(295, 53);
            this.buttonFetchEvents.TabIndex = 4;
            this.buttonFetchEvents.Text = "Fetch events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(6, 80);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 102;
            this.dataGridViewEvents.RowTemplate.Height = 40;
            this.dataGridViewEvents.Size = new System.Drawing.Size(2508, 1157);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Location = new System.Drawing.Point(10, 51);
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.Size = new System.Drawing.Size(2520, 1243);
            this.m_MutualLikedPagesTab.TabIndex = 2;
            this.m_MutualLikedPagesTab.Text = "Mutual Liked Pages";
            this.m_MutualLikedPagesTab.UseVisualStyleBackColor = true;
            // 
            // m_UserProfilePicture
            // 
            this.m_UserProfilePicture.Image = global::BasicFacebookFeatures.Properties.Resources.FacebookLogo;
            this.m_UserProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("m_UserProfilePicture.InitialImage")));
            this.m_UserProfilePicture.Location = new System.Drawing.Point(1157, 36);
            this.m_UserProfilePicture.Name = "m_UserProfilePicture";
            this.m_UserProfilePicture.Size = new System.Drawing.Size(210, 216);
            this.m_UserProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_UserProfilePicture.TabIndex = 54;
            this.m_UserProfilePicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // m_HelloUserLabel
            // 
            this.m_HelloUserLabel.AutoSize = true;
            this.m_HelloUserLabel.Location = new System.Drawing.Point(1396, 128);
            this.m_HelloUserLabel.Name = "m_HelloUserLabel";
            this.m_HelloUserLabel.Size = new System.Drawing.Size(168, 32);
            this.m_HelloUserLabel.TabIndex = 55;
            this.m_HelloUserLabel.Text = "Hello friend!";
            // 
            // comboBoxEventsStatus
            // 
            this.comboBoxEventsStatus.FormattingEnabled = true;
            this.comboBoxEventsStatus.Items.AddRange(new object[] {
            "Online envents",
            "Physical attendance events",
            "All events"});
            this.comboBoxEventsStatus.Location = new System.Drawing.Point(22, 14);
            this.comboBoxEventsStatus.Name = "comboBoxEventsStatus";
            this.comboBoxEventsStatus.Size = new System.Drawing.Size(469, 41);
            this.comboBoxEventsStatus.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2569, 1616);
            this.Controls.Add(this.m_HelloUserLabel);
            this.Controls.Add(this.m_UserProfilePicture);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2279, 1600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.m_MainTab.ResumeLayout(false);
            this.m_MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_FetchEventsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePicture)).EndInit();
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
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label m_HelloUserLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ComboBox comboBoxEventsStatus;
    }
}

