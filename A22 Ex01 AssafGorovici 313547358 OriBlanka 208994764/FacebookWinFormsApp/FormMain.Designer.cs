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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonFetchFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikedPages = new System.Windows.Forms.Button();
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
            this.buttonLogin.Location = new System.Drawing.Point(15, 15);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(7);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(438, 55);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(2054, 19);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(7);
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
            this.tabControl1.Size = new System.Drawing.Size(2222, 1220);
            this.tabControl1.TabIndex = 53;
            // 
            // m_MainTab
            // 
            this.m_MainTab.Controls.Add(this.linkLabel1);
            this.m_MainTab.Controls.Add(this.pictureBox5);
            this.m_MainTab.Controls.Add(this.listBoxFriends);
            this.m_MainTab.Controls.Add(this.buttonFetchFriends);
            this.m_MainTab.Controls.Add(this.pictureBox4);
            this.m_MainTab.Controls.Add(this.pictureBox3);
            this.m_MainTab.Controls.Add(this.pictureBox2);
            this.m_MainTab.Controls.Add(this.pictureBox1);
            this.m_MainTab.Controls.Add(this.buttonFetchFavoriteTeams);
            this.m_MainTab.Controls.Add(this.buttonFetchAlbums);
            this.m_MainTab.Controls.Add(this.listBoxFavoriteTeams);
            this.m_MainTab.Controls.Add(this.listBoxAlbums);
            this.m_MainTab.Controls.Add(this.listBoxGroups);
            this.m_MainTab.Controls.Add(this.buttonFetchGroups);
            this.m_MainTab.Controls.Add(this.listBoxLikedPages);
            this.m_MainTab.Controls.Add(this.buttonLikedPages);
            this.m_MainTab.Controls.Add(this.buttonFetchPosts);
            this.m_MainTab.Controls.Add(this.listBoxPosts);
            this.m_MainTab.Location = new System.Drawing.Point(10, 49);
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_MainTab.Size = new System.Drawing.Size(2202, 1161);
            this.m_MainTab.TabIndex = 0;
            this.m_MainTab.Text = "Main";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(522, 967);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 31);
            this.linkLabel1.TabIndex = 73;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(1882, 312);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(216, 123);
            this.pictureBox5.TabIndex = 72;
            this.pictureBox5.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 31;
            this.listBoxFriends.Location = new System.Drawing.Point(1540, 455);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(604, 97);
            this.listBoxFriends.TabIndex = 71;
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(1550, 316);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(211, 102);
            this.buttonFetchFriends.TabIndex = 70;
            this.buttonFetchFriends.Text = "Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1900, 708);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(216, 123);
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(385, 671);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 123);
            this.pictureBox3.TabIndex = 68;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1138, 695);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 123);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(385, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 123);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(1558, 716);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(235, 85);
            this.buttonFetchFavoriteTeams.TabIndex = 65;
            this.buttonFetchFavoriteTeams.Text = "Favorite Teams";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(52, 709);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(235, 85);
            this.buttonFetchAlbums.TabIndex = 64;
            this.buttonFetchAlbums.Text = "Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 31;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(1540, 837);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(604, 97);
            this.listBoxFavoriteTeams.TabIndex = 63;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 31;
            this.listBoxAlbums.Location = new System.Drawing.Point(52, 837);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(604, 97);
            this.listBoxAlbums.TabIndex = 62;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 31;
            this.listBoxGroups.Location = new System.Drawing.Point(796, 837);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(604, 97);
            this.listBoxGroups.TabIndex = 61;
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(807, 699);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(211, 102);
            this.buttonFetchGroups.TabIndex = 60;
            this.buttonFetchGroups.Text = "Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 31;
            this.listBoxLikedPages.Location = new System.Drawing.Point(52, 455);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(604, 97);
            this.listBoxLikedPages.TabIndex = 59;
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(52, 333);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(235, 85);
            this.buttonLikedPages.TabIndex = 58;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(186, 101);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(251, 108);
            this.buttonFetchPosts.TabIndex = 57;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 31;
            this.listBoxPosts.Location = new System.Drawing.Point(543, 63);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(1315, 159);
            this.listBoxPosts.TabIndex = 56;
            // 
            // m_FetchEventsTab
            // 
            this.m_FetchEventsTab.Controls.Add(this.comboBoxEventsStatus);
            this.m_FetchEventsTab.Controls.Add(this.buttonFetchEvents);
            this.m_FetchEventsTab.Controls.Add(this.dataGridViewEvents);
            this.m_FetchEventsTab.Location = new System.Drawing.Point(10, 49);
            this.m_FetchEventsTab.Name = "m_FetchEventsTab";
            this.m_FetchEventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FetchEventsTab.Size = new System.Drawing.Size(2202, 1161);
            this.m_FetchEventsTab.TabIndex = 1;
            this.m_FetchEventsTab.Text = "My Events";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(509, 7);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(258, 50);
            this.buttonFetchEvents.TabIndex = 4;
            this.buttonFetchEvents.Text = "Fetch events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Location = new System.Drawing.Point(5, 75);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersWidth = 102;
            this.dataGridViewEvents.RowTemplate.Height = 40;
            this.dataGridViewEvents.Size = new System.Drawing.Size(2194, 1082);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Location = new System.Drawing.Point(10, 49);
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.Size = new System.Drawing.Size(2202, 1161);
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
            this.m_UserProfilePicture.Size = new System.Drawing.Size(184, 202);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2248, 1512);
            this.Controls.Add(this.m_HelloUserLabel);
            this.Controls.Add(this.m_UserProfilePicture);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1998, 1502);
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
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label m_HelloUserLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ComboBox comboBoxEventsStatus;
    }
}

