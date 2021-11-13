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
            this.m_LoginButton = new System.Windows.Forms.Button();
            this.m_LogoutButton = new System.Windows.Forms.Button();
            this.m_AppTabControl = new System.Windows.Forms.TabControl();
            this.m_MainTab = new System.Windows.Forms.TabPage();
            this.m_SelectedLikedPagePictureBox = new System.Windows.Forms.PictureBox();
            this.m_RandomImagePictureBox = new System.Windows.Forms.PictureBox();
            this.m_FetchRandomPictureButton = new System.Windows.Forms.Button();
            this.m_SelectedGroupPictureBox = new System.Windows.Forms.PictureBox();
            this.m_SelectedAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.m_FetchGroupsButton = new System.Windows.Forms.Button();
            this.m_FetchAlbumsButton = new System.Windows.Forms.Button();
            this.m_GroupsListBox = new System.Windows.Forms.ListBox();
            this.m_AlbumsListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingBirthdayListBox = new System.Windows.Forms.ListBox();
            this.m_FetchUpcomingBirthdayButton = new System.Windows.Forms.Button();
            this.m_LikedPagesListBox = new System.Windows.Forms.ListBox();
            this.m_LikedPagesButton = new System.Windows.Forms.Button();
            this.m_FetchPostsButton = new System.Windows.Forms.Button();
            this.m_PostsListBox = new System.Windows.Forms.ListBox();
            this.m_FetchEventsTab = new System.Windows.Forms.TabPage();
            this.m_EventStatusComboBox = new System.Windows.Forms.ComboBox();
            this.m_FetchEventButtons = new System.Windows.Forms.Button();
            this.m_EventGridView = new System.Windows.Forms.DataGridView();
            this.m_MutualLikedPagesTab = new System.Windows.Forms.TabPage();
            this.m_CommonInterestListBox = new System.Windows.Forms.ListBox();
            this.m_FetchCommonInterest = new System.Windows.Forms.Button();
            this.m_LikePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_HelloUserLabel = new System.Windows.Forms.Label();
            this.m_UserProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_AppTabControl.SuspendLayout();
            this.m_MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_SelectedLikedPagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_SelectedGroupPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_SelectedAlbumPictureBox)).BeginInit();
            this.m_FetchEventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_EventGridView)).BeginInit();
            this.m_MutualLikedPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LikePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // m_LoginButton
            // 
            this.m_LoginButton.Location = new System.Drawing.Point(17, 16);
            this.m_LoginButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_LoginButton.Name = "m_LoginButton";
            this.m_LoginButton.Size = new System.Drawing.Size(501, 59);
            this.m_LoginButton.TabIndex = 36;
            this.m_LoginButton.Text = "Login";
            this.m_LoginButton.UseVisualStyleBackColor = true;
            this.m_LoginButton.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_LogoutButton
            // 
            this.m_LogoutButton.Location = new System.Drawing.Point(2347, 20);
            this.m_LogoutButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.Size = new System.Drawing.Size(193, 55);
            this.m_LogoutButton.TabIndex = 52;
            this.m_LogoutButton.Text = "Logout";
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_AppTabControl
            // 
            this.m_AppTabControl.Controls.Add(this.m_MainTab);
            this.m_AppTabControl.Controls.Add(this.m_FetchEventsTab);
            this.m_AppTabControl.Controls.Add(this.m_MutualLikedPagesTab);
            this.m_AppTabControl.Font = new System.Drawing.Font("Miriam", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_AppTabControl.Location = new System.Drawing.Point(17, 238);
            this.m_AppTabControl.Name = "m_AppTabControl";
            this.m_AppTabControl.SelectedIndex = 0;
            this.m_AppTabControl.Size = new System.Drawing.Size(2539, 1304);
            this.m_AppTabControl.TabIndex = 53;
            // 
            // m_MainTab
            // 
            this.m_MainTab.Controls.Add(this.m_SelectedLikedPagePictureBox);
            this.m_MainTab.Controls.Add(this.m_RandomImagePictureBox);
            this.m_MainTab.Controls.Add(this.m_FetchRandomPictureButton);
            this.m_MainTab.Controls.Add(this.m_SelectedGroupPictureBox);
            this.m_MainTab.Controls.Add(this.m_SelectedAlbumPictureBox);
            this.m_MainTab.Controls.Add(this.m_FetchGroupsButton);
            this.m_MainTab.Controls.Add(this.m_FetchAlbumsButton);
            this.m_MainTab.Controls.Add(this.m_GroupsListBox);
            this.m_MainTab.Controls.Add(this.m_AlbumsListBox);
            this.m_MainTab.Controls.Add(this.m_UpcomingBirthdayListBox);
            this.m_MainTab.Controls.Add(this.m_FetchUpcomingBirthdayButton);
            this.m_MainTab.Controls.Add(this.m_LikedPagesListBox);
            this.m_MainTab.Controls.Add(this.m_LikedPagesButton);
            this.m_MainTab.Controls.Add(this.m_FetchPostsButton);
            this.m_MainTab.Controls.Add(this.m_PostsListBox);
            this.m_MainTab.Location = new System.Drawing.Point(10, 51);
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_MainTab.Size = new System.Drawing.Size(2519, 1243);
            this.m_MainTab.TabIndex = 0;
            this.m_MainTab.Text = "Main";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // m_SelectedLikedPagePictureBox
            // 
            this.m_SelectedLikedPagePictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.m_SelectedLikedPagePictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.m_SelectedLikedPagePictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.m_SelectedLikedPagePictureBox.Location = new System.Drawing.Point(397, 315);
            this.m_SelectedLikedPagePictureBox.Name = "m_SelectedLikedPagePictureBox";
            this.m_SelectedLikedPagePictureBox.Size = new System.Drawing.Size(243, 150);
            this.m_SelectedLikedPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_SelectedLikedPagePictureBox.TabIndex = 74;
            this.m_SelectedLikedPagePictureBox.TabStop = false;
            // 
            // m_RandomImagePictureBox
            // 
            this.m_RandomImagePictureBox.Location = new System.Drawing.Point(1000, 486);
            this.m_RandomImagePictureBox.Name = "m_RandomImagePictureBox";
            this.m_RandomImagePictureBox.Size = new System.Drawing.Size(526, 487);
            this.m_RandomImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_RandomImagePictureBox.TabIndex = 72;
            this.m_RandomImagePictureBox.TabStop = false;
            // 
            // m_FetchRandomPictureButton
            // 
            this.m_FetchRandomPictureButton.Location = new System.Drawing.Point(1099, 338);
            this.m_FetchRandomPictureButton.Name = "m_FetchRandomPictureButton";
            this.m_FetchRandomPictureButton.Size = new System.Drawing.Size(338, 109);
            this.m_FetchRandomPictureButton.TabIndex = 70;
            this.m_FetchRandomPictureButton.Text = "Random Picture";
            this.m_FetchRandomPictureButton.UseVisualStyleBackColor = true;
            this.m_FetchRandomPictureButton.Click += new System.EventHandler(this.buttonFetchRandomPicture_Click);
            // 
            // m_SelectedGroupPictureBox
            // 
            this.m_SelectedGroupPictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.m_SelectedGroupPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.m_SelectedGroupPictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.m_SelectedGroupPictureBox.Location = new System.Drawing.Point(2115, 700);
            this.m_SelectedGroupPictureBox.Name = "m_SelectedGroupPictureBox";
            this.m_SelectedGroupPictureBox.Size = new System.Drawing.Size(303, 174);
            this.m_SelectedGroupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_SelectedGroupPictureBox.TabIndex = 69;
            this.m_SelectedGroupPictureBox.TabStop = false;
            // 
            // m_SelectedAlbumPictureBox
            // 
            this.m_SelectedAlbumPictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.pictureaalbum;
            this.m_SelectedAlbumPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.pictureaalbum;
            this.m_SelectedAlbumPictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.pictureaalbum;
            this.m_SelectedAlbumPictureBox.Location = new System.Drawing.Point(397, 691);
            this.m_SelectedAlbumPictureBox.Name = "m_SelectedAlbumPictureBox";
            this.m_SelectedAlbumPictureBox.Size = new System.Drawing.Size(259, 184);
            this.m_SelectedAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_SelectedAlbumPictureBox.TabIndex = 68;
            this.m_SelectedAlbumPictureBox.TabStop = false;
            // 
            // m_FetchGroupsButton
            // 
            this.m_FetchGroupsButton.Location = new System.Drawing.Point(1781, 765);
            this.m_FetchGroupsButton.Name = "m_FetchGroupsButton";
            this.m_FetchGroupsButton.Size = new System.Drawing.Size(269, 91);
            this.m_FetchGroupsButton.TabIndex = 65;
            this.m_FetchGroupsButton.Text = "Grups";
            this.m_FetchGroupsButton.UseVisualStyleBackColor = true;
            this.m_FetchGroupsButton.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // m_FetchAlbumsButton
            // 
            this.m_FetchAlbumsButton.Location = new System.Drawing.Point(59, 758);
            this.m_FetchAlbumsButton.Name = "m_FetchAlbumsButton";
            this.m_FetchAlbumsButton.Size = new System.Drawing.Size(269, 91);
            this.m_FetchAlbumsButton.TabIndex = 64;
            this.m_FetchAlbumsButton.Text = "Albums";
            this.m_FetchAlbumsButton.UseVisualStyleBackColor = true;
            this.m_FetchAlbumsButton.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // m_GroupsListBox
            // 
            this.m_GroupsListBox.FormattingEnabled = true;
            this.m_GroupsListBox.ItemHeight = 33;
            this.m_GroupsListBox.Location = new System.Drawing.Point(1760, 895);
            this.m_GroupsListBox.Name = "m_GroupsListBox";
            this.m_GroupsListBox.Size = new System.Drawing.Size(690, 103);
            this.m_GroupsListBox.TabIndex = 63;
            this.m_GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // m_AlbumsListBox
            // 
            this.m_AlbumsListBox.FormattingEnabled = true;
            this.m_AlbumsListBox.ItemHeight = 33;
            this.m_AlbumsListBox.Location = new System.Drawing.Point(59, 895);
            this.m_AlbumsListBox.Name = "m_AlbumsListBox";
            this.m_AlbumsListBox.Size = new System.Drawing.Size(690, 103);
            this.m_AlbumsListBox.TabIndex = 62;
            this.m_AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // m_UpcomingBirthdayListBox
            // 
            this.m_UpcomingBirthdayListBox.FormattingEnabled = true;
            this.m_UpcomingBirthdayListBox.ItemHeight = 33;
            this.m_UpcomingBirthdayListBox.Location = new System.Drawing.Point(1760, 531);
            this.m_UpcomingBirthdayListBox.Name = "m_UpcomingBirthdayListBox";
            this.m_UpcomingBirthdayListBox.Size = new System.Drawing.Size(690, 103);
            this.m_UpcomingBirthdayListBox.TabIndex = 61;
            // 
            // m_FetchUpcomingBirthdayButton
            // 
            this.m_FetchUpcomingBirthdayButton.Location = new System.Drawing.Point(1920, 362);
            this.m_FetchUpcomingBirthdayButton.Name = "m_FetchUpcomingBirthdayButton";
            this.m_FetchUpcomingBirthdayButton.Size = new System.Drawing.Size(355, 109);
            this.m_FetchUpcomingBirthdayButton.TabIndex = 60;
            this.m_FetchUpcomingBirthdayButton.Text = "Upcoming Birthdays";
            this.m_FetchUpcomingBirthdayButton.UseVisualStyleBackColor = true;
            this.m_FetchUpcomingBirthdayButton.Click += new System.EventHandler(this.buttonFetchUpcomingBirthdays_Click);
            // 
            // m_LikedPagesListBox
            // 
            this.m_LikedPagesListBox.FormattingEnabled = true;
            this.m_LikedPagesListBox.ItemHeight = 33;
            this.m_LikedPagesListBox.Location = new System.Drawing.Point(67, 531);
            this.m_LikedPagesListBox.Name = "m_LikedPagesListBox";
            this.m_LikedPagesListBox.Size = new System.Drawing.Size(690, 103);
            this.m_LikedPagesListBox.TabIndex = 59;
            this.m_LikedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // m_LikedPagesButton
            // 
            this.m_LikedPagesButton.Location = new System.Drawing.Point(67, 371);
            this.m_LikedPagesButton.Name = "m_LikedPagesButton";
            this.m_LikedPagesButton.Size = new System.Drawing.Size(269, 91);
            this.m_LikedPagesButton.TabIndex = 58;
            this.m_LikedPagesButton.Text = "Liked Pages";
            this.m_LikedPagesButton.UseVisualStyleBackColor = true;
            this.m_LikedPagesButton.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // m_FetchPostsButton
            // 
            this.m_FetchPostsButton.Location = new System.Drawing.Point(304, 67);
            this.m_FetchPostsButton.Name = "m_FetchPostsButton";
            this.m_FetchPostsButton.Size = new System.Drawing.Size(287, 103);
            this.m_FetchPostsButton.TabIndex = 57;
            this.m_FetchPostsButton.Text = "Fetch Posts";
            this.m_FetchPostsButton.UseVisualStyleBackColor = true;
            this.m_FetchPostsButton.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // m_PostsListBox
            // 
            this.m_PostsListBox.FormattingEnabled = true;
            this.m_PostsListBox.ItemHeight = 33;
            this.m_PostsListBox.Location = new System.Drawing.Point(621, 67);
            this.m_PostsListBox.Name = "m_PostsListBox";
            this.m_PostsListBox.Size = new System.Drawing.Size(1502, 103);
            this.m_PostsListBox.TabIndex = 56;
            // 
            // m_FetchEventsTab
            // 
            this.m_FetchEventsTab.Controls.Add(this.m_EventStatusComboBox);
            this.m_FetchEventsTab.Controls.Add(this.m_FetchEventButtons);
            this.m_FetchEventsTab.Controls.Add(this.m_EventGridView);
            this.m_FetchEventsTab.Location = new System.Drawing.Point(10, 51);
            this.m_FetchEventsTab.Name = "m_FetchEventsTab";
            this.m_FetchEventsTab.Padding = new System.Windows.Forms.Padding(3);
            this.m_FetchEventsTab.Size = new System.Drawing.Size(2519, 1243);
            this.m_FetchEventsTab.TabIndex = 1;
            this.m_FetchEventsTab.Text = "My Events";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // m_EventStatusComboBox
            // 
            this.m_EventStatusComboBox.FormattingEnabled = true;
            this.m_EventStatusComboBox.Items.AddRange(new object[] {
            "Online envents",
            "Physical attendance events",
            "All events"});
            this.m_EventStatusComboBox.Location = new System.Drawing.Point(25, 15);
            this.m_EventStatusComboBox.Name = "m_EventStatusComboBox";
            this.m_EventStatusComboBox.Size = new System.Drawing.Size(535, 41);
            this.m_EventStatusComboBox.TabIndex = 5;
            // 
            // m_FetchEventButtons
            // 
            this.m_FetchEventButtons.Location = new System.Drawing.Point(582, 7);
            this.m_FetchEventButtons.Name = "m_FetchEventButtons";
            this.m_FetchEventButtons.Size = new System.Drawing.Size(295, 53);
            this.m_FetchEventButtons.TabIndex = 4;
            this.m_FetchEventButtons.Text = "Fetch events";
            this.m_FetchEventButtons.UseVisualStyleBackColor = true;
            this.m_FetchEventButtons.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // m_EventGridView
            // 
            this.m_EventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_EventGridView.Location = new System.Drawing.Point(6, 80);
            this.m_EventGridView.Name = "m_EventGridView";
            this.m_EventGridView.RowHeadersWidth = 102;
            this.m_EventGridView.RowTemplate.Height = 40;
            this.m_EventGridView.Size = new System.Drawing.Size(2507, 1157);
            this.m_EventGridView.TabIndex = 0;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Controls.Add(this.m_CommonInterestListBox);
            this.m_MutualLikedPagesTab.Controls.Add(this.m_FetchCommonInterest);
            this.m_MutualLikedPagesTab.Controls.Add(this.m_LikePictureBox);
            this.m_MutualLikedPagesTab.Location = new System.Drawing.Point(10, 51);
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.Size = new System.Drawing.Size(2519, 1243);
            this.m_MutualLikedPagesTab.TabIndex = 2;
            this.m_MutualLikedPagesTab.Text = "Mutual Liked Pages";
            this.m_MutualLikedPagesTab.UseVisualStyleBackColor = true;
            // 
            // m_CommonInterestListBox
            // 
            this.m_CommonInterestListBox.FormattingEnabled = true;
            this.m_CommonInterestListBox.ItemHeight = 33;
            this.m_CommonInterestListBox.Location = new System.Drawing.Point(714, 224);
            this.m_CommonInterestListBox.Name = "m_CommonInterestListBox";
            this.m_CommonInterestListBox.Size = new System.Drawing.Size(1083, 565);
            this.m_CommonInterestListBox.TabIndex = 2;
            // 
            // m_FetchCommonInterest
            // 
            this.m_FetchCommonInterest.Location = new System.Drawing.Point(869, 90);
            this.m_FetchCommonInterest.Name = "m_FetchCommonInterest";
            this.m_FetchCommonInterest.Size = new System.Drawing.Size(728, 96);
            this.m_FetchCommonInterest.TabIndex = 1;
            this.m_FetchCommonInterest.Text = "Click here to see your friends that like similar pages";
            this.m_FetchCommonInterest.UseVisualStyleBackColor = true;
            this.m_FetchCommonInterest.Click += new System.EventHandler(this.buttonCommonInterest_Click);
            // 
            // m_LikePictureBox
            // 
            this.m_LikePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("m_LikePictureBox.Image")));
            this.m_LikePictureBox.Location = new System.Drawing.Point(2141, 958);
            this.m_LikePictureBox.Name = "m_LikePictureBox";
            this.m_LikePictureBox.Size = new System.Drawing.Size(362, 267);
            this.m_LikePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_LikePictureBox.TabIndex = 0;
            this.m_LikePictureBox.TabStop = false;
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
            this.Controls.Add(this.m_LogoutButton);
            this.Controls.Add(this.m_AppTabControl);
            this.Controls.Add(this.m_LoginButton);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(2279, 1600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Our Facebook App";
            this.m_AppTabControl.ResumeLayout(false);
            this.m_MainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_SelectedLikedPagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_SelectedGroupPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_SelectedAlbumPictureBox)).EndInit();
            this.m_FetchEventsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_EventGridView)).EndInit();
            this.m_MutualLikedPagesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_LikePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_UserProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button m_LoginButton;
		private System.Windows.Forms.Button m_LogoutButton;
        private System.Windows.Forms.TabControl m_AppTabControl;
        private System.Windows.Forms.TabPage m_MainTab;
        private System.Windows.Forms.TabPage m_FetchEventsTab;
        private System.Windows.Forms.TabPage m_MutualLikedPagesTab;
        private System.Windows.Forms.PictureBox m_UserProfilePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox m_SelectedGroupPictureBox;
        private System.Windows.Forms.PictureBox m_SelectedAlbumPictureBox;
        private System.Windows.Forms.Button m_FetchGroupsButton;
        private System.Windows.Forms.Button m_FetchAlbumsButton;
        private System.Windows.Forms.ListBox m_GroupsListBox;
        private System.Windows.Forms.ListBox m_AlbumsListBox;
        private System.Windows.Forms.ListBox m_UpcomingBirthdayListBox;
        private System.Windows.Forms.Button m_FetchUpcomingBirthdayButton;
        private System.Windows.Forms.ListBox m_LikedPagesListBox;
        private System.Windows.Forms.Button m_LikedPagesButton;
        private System.Windows.Forms.Button m_FetchPostsButton;
        private System.Windows.Forms.ListBox m_PostsListBox;
        private System.Windows.Forms.Label m_HelloUserLabel;
        private System.Windows.Forms.PictureBox m_RandomImagePictureBox;
        private System.Windows.Forms.Button m_FetchRandomPictureButton;
        private System.Windows.Forms.DataGridView m_EventGridView;
        private System.Windows.Forms.Button m_FetchEventButtons;
        private System.Windows.Forms.ComboBox m_EventStatusComboBox;
        private System.Windows.Forms.PictureBox m_SelectedLikedPagePictureBox;
        private System.Windows.Forms.PictureBox m_LikePictureBox;
        private System.Windows.Forms.ListBox m_CommonInterestListBox;
        private System.Windows.Forms.Button m_FetchCommonInterest;
    }
}

