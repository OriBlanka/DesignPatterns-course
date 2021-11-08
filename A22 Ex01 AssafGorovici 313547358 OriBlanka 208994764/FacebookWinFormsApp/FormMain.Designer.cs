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
            this.pictureBoxSelectedLikedPage = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBoxRandomPicture = new System.Windows.Forms.PictureBox();
            this.buttonFetchRandomPicture = new System.Windows.Forms.Button();
            this.pictureBoxSelectedFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.pictureBoxSelectedAlbum = new System.Windows.Forms.PictureBox();
            this.buttonFetchFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.listBoxUpcomingBirthdays = new System.Windows.Forms.ListBox();
            this.buttonFetchUpcomingBirthdays = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.m_FetchEventsTab = new System.Windows.Forms.TabPage();
            this.comboBoxEventsStatus = new System.Windows.Forms.ComboBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.m_MutualLikedPagesTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.m_HelloUserLabel = new System.Windows.Forms.Label();
            this.m_UserProfilePicture = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.m_MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedLikedPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbum)).BeginInit();
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
            this.buttonLogout.Location = new System.Drawing.Point(2347, 20);
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
            this.tabControl1.Size = new System.Drawing.Size(2539, 1304);
            this.tabControl1.TabIndex = 53;
            // 
            // m_MainTab
            // 
            this.m_MainTab.Controls.Add(this.pictureBoxSelectedLikedPage);
            this.m_MainTab.Controls.Add(this.linkLabel1);
            this.m_MainTab.Controls.Add(this.pictureBoxRandomPicture);
            this.m_MainTab.Controls.Add(this.buttonFetchRandomPicture);
            this.m_MainTab.Controls.Add(this.pictureBoxSelectedFavoriteTeam);
            this.m_MainTab.Controls.Add(this.pictureBoxSelectedAlbum);
            this.m_MainTab.Controls.Add(this.buttonFetchFavoriteTeams);
            this.m_MainTab.Controls.Add(this.buttonFetchAlbums);
            this.m_MainTab.Controls.Add(this.listBoxFavoriteTeams);
            this.m_MainTab.Controls.Add(this.listBoxAlbums);
            this.m_MainTab.Controls.Add(this.listBoxUpcomingBirthdays);
            this.m_MainTab.Controls.Add(this.buttonFetchUpcomingBirthdays);
            this.m_MainTab.Controls.Add(this.listBoxLikedPages);
            this.m_MainTab.Controls.Add(this.buttonLikedPages);
            this.m_MainTab.Controls.Add(this.buttonFetchPosts);
            this.m_MainTab.Controls.Add(this.listBoxPosts);
            this.m_MainTab.Location = new System.Drawing.Point(10, 51);
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_MainTab.Size = new System.Drawing.Size(2519, 1243);
            this.m_MainTab.TabIndex = 0;
            this.m_MainTab.Text = "Main";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSelectedLikedPage
            // 
            this.pictureBoxSelectedLikedPage.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.pictureBoxSelectedLikedPage.Image = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.pictureBoxSelectedLikedPage.InitialImage = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.pictureBoxSelectedLikedPage.Location = new System.Drawing.Point(397, 315);
            this.pictureBoxSelectedLikedPage.Name = "pictureBoxSelectedLikedPage";
            this.pictureBoxSelectedLikedPage.Size = new System.Drawing.Size(243, 150);
            this.pictureBoxSelectedLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedLikedPage.TabIndex = 74;
            this.pictureBoxSelectedLikedPage.TabStop = false;
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
            // pictureBoxRandomPicture
            // 
            this.pictureBoxRandomPicture.Location = new System.Drawing.Point(1000, 486);
            this.pictureBoxRandomPicture.Name = "pictureBoxRandomPicture";
            this.pictureBoxRandomPicture.Size = new System.Drawing.Size(526, 487);
            this.pictureBoxRandomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRandomPicture.TabIndex = 72;
            this.pictureBoxRandomPicture.TabStop = false;
            // 
            // buttonFetchRandomPicture
            // 
            this.buttonFetchRandomPicture.Location = new System.Drawing.Point(1099, 338);
            this.buttonFetchRandomPicture.Name = "buttonFetchRandomPicture";
            this.buttonFetchRandomPicture.Size = new System.Drawing.Size(338, 109);
            this.buttonFetchRandomPicture.TabIndex = 70;
            this.buttonFetchRandomPicture.Text = "Random Picture";
            this.buttonFetchRandomPicture.UseVisualStyleBackColor = true;
            this.buttonFetchRandomPicture.Click += new System.EventHandler(this.buttonFetchRandomPicture_Click);
            // 
            // pictureBoxSelectedFavoriteTeam
            // 
            this.pictureBoxSelectedFavoriteTeam.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.pictureBoxSelectedFavoriteTeam.Image = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.pictureBoxSelectedFavoriteTeam.InitialImage = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.pictureBoxSelectedFavoriteTeam.Location = new System.Drawing.Point(2115, 700);
            this.pictureBoxSelectedFavoriteTeam.Name = "pictureBoxSelectedFavoriteTeam";
            this.pictureBoxSelectedFavoriteTeam.Size = new System.Drawing.Size(303, 174);
            this.pictureBoxSelectedFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedFavoriteTeam.TabIndex = 69;
            this.pictureBoxSelectedFavoriteTeam.TabStop = false;
            // 
            // pictureBoxSelectedAlbum
            // 
            this.pictureBoxSelectedAlbum.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.albumPicDefault;
            this.pictureBoxSelectedAlbum.Image = global::BasicFacebookFeatures.Properties.Resources.albumPicDefault;
            this.pictureBoxSelectedAlbum.InitialImage = global::BasicFacebookFeatures.Properties.Resources.albumPicDefault;
            this.pictureBoxSelectedAlbum.Location = new System.Drawing.Point(397, 691);
            this.pictureBoxSelectedAlbum.Name = "pictureBoxSelectedAlbum";
            this.pictureBoxSelectedAlbum.Size = new System.Drawing.Size(259, 184);
            this.pictureBoxSelectedAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedAlbum.TabIndex = 68;
            this.pictureBoxSelectedAlbum.TabStop = false;
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(1781, 765);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(269, 91);
            this.buttonFetchFavoriteTeams.TabIndex = 65;
            this.buttonFetchFavoriteTeams.Text = "Favorite Teams";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Location = new System.Drawing.Point(59, 758);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(269, 91);
            this.buttonFetchAlbums.TabIndex = 64;
            this.buttonFetchAlbums.Text = "Albums";
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 33;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(1760, 895);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(690, 103);
            this.listBoxFavoriteTeams.TabIndex = 63;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 33;
            this.listBoxAlbums.Location = new System.Drawing.Point(59, 895);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(690, 103);
            this.listBoxAlbums.TabIndex = 62;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // listBoxUpcomingBirthdays
            // 
            this.listBoxUpcomingBirthdays.FormattingEnabled = true;
            this.listBoxUpcomingBirthdays.ItemHeight = 33;
            this.listBoxUpcomingBirthdays.Location = new System.Drawing.Point(1750, 486);
            this.listBoxUpcomingBirthdays.Name = "listBoxUpcomingBirthdays";
            this.listBoxUpcomingBirthdays.Size = new System.Drawing.Size(690, 103);
            this.listBoxUpcomingBirthdays.TabIndex = 61;
            // 
            // buttonFetchUpcomingBirthdays
            // 
            this.buttonFetchUpcomingBirthdays.Location = new System.Drawing.Point(1930, 327);
            this.buttonFetchUpcomingBirthdays.Name = "buttonFetchUpcomingBirthdays";
            this.buttonFetchUpcomingBirthdays.Size = new System.Drawing.Size(355, 109);
            this.buttonFetchUpcomingBirthdays.TabIndex = 60;
            this.buttonFetchUpcomingBirthdays.Text = "Upcoming Birthdays";
            this.buttonFetchUpcomingBirthdays.UseVisualStyleBackColor = true;
            this.buttonFetchUpcomingBirthdays.Click += new System.EventHandler(this.buttonFetchUpcomingBirthdays_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 33;
            this.listBoxLikedPages.Location = new System.Drawing.Point(59, 486);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(690, 103);
            this.listBoxLikedPages.TabIndex = 59;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(59, 356);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(269, 91);
            this.buttonLikedPages.TabIndex = 58;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
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
            this.listBoxPosts.Size = new System.Drawing.Size(1502, 103);
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
            this.m_FetchEventsTab.Size = new System.Drawing.Size(2519, 1243);
            this.m_FetchEventsTab.TabIndex = 1;
            this.m_FetchEventsTab.Text = "My Events";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxEventsStatus
            // 
            this.comboBoxEventsStatus.FormattingEnabled = true;
            this.comboBoxEventsStatus.Items.AddRange(new object[] {
            "Online envents",
            "Physical attendance events",
            "All events"});
            this.comboBoxEventsStatus.Location = new System.Drawing.Point(25, 15);
            this.comboBoxEventsStatus.Name = "comboBoxEventsStatus";
            this.comboBoxEventsStatus.Size = new System.Drawing.Size(535, 41);
            this.comboBoxEventsStatus.TabIndex = 5;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(582, 7);
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
            this.dataGridViewEvents.Size = new System.Drawing.Size(2507, 1157);
            this.dataGridViewEvents.TabIndex = 0;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Location = new System.Drawing.Point(10, 51);
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.Size = new System.Drawing.Size(2519, 1243);
            this.m_MutualLikedPagesTab.TabIndex = 2;
            this.m_MutualLikedPagesTab.Text = "Mutual Liked Pages";
            this.m_MutualLikedPagesTab.UseVisualStyleBackColor = true;
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
            this.m_HelloUserLabel.Location = new System.Drawing.Point(1418, 119);
            this.m_HelloUserLabel.Name = "m_HelloUserLabel";
            this.m_HelloUserLabel.Size = new System.Drawing.Size(168, 32);
            this.m_HelloUserLabel.TabIndex = 55;
            this.m_HelloUserLabel.Text = "Hello friend!";
            // 
            // m_UserProfilePicture
            // 
            this.m_UserProfilePicture.Image = global::BasicFacebookFeatures.Properties.Resources.FacebookLogo;
            this.m_UserProfilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("m_UserProfilePicture.InitialImage")));
            this.m_UserProfilePicture.Location = new System.Drawing.Point(1145, 20);
            this.m_UserProfilePicture.Name = "m_UserProfilePicture";
            this.m_UserProfilePicture.Size = new System.Drawing.Size(210, 216);
            this.m_UserProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_UserProfilePicture.TabIndex = 54;
            this.m_UserProfilePicture.TabStop = false;
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
            this.Text = "Our Facebook App";
            this.tabControl1.ResumeLayout(false);
            this.m_MainTab.ResumeLayout(false);
            this.m_MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedLikedPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRandomPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFavoriteTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedAlbum)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxSelectedFavoriteTeam;
        private System.Windows.Forms.PictureBox pictureBoxSelectedAlbum;
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxUpcomingBirthdays;
        private System.Windows.Forms.Button buttonFetchUpcomingBirthdays;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label m_HelloUserLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBoxRandomPicture;
        private System.Windows.Forms.Button buttonFetchRandomPicture;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ComboBox comboBoxEventsStatus;
        private System.Windows.Forms.PictureBox pictureBoxSelectedLikedPage;
    }
}

