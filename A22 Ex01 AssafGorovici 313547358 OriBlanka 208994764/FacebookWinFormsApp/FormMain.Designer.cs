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
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
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
            resources.ApplyResources(this.m_LoginButton, "m_LoginButton");
            this.m_LoginButton.Name = "m_LoginButton";
            this.m_LoginButton.UseVisualStyleBackColor = true;
            this.m_LoginButton.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // m_LogoutButton
            // 
            resources.ApplyResources(this.m_LogoutButton, "m_LogoutButton");
            this.m_LogoutButton.Name = "m_LogoutButton";
            this.m_LogoutButton.UseVisualStyleBackColor = true;
            this.m_LogoutButton.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_AppTabControl
            // 
            this.m_AppTabControl.Controls.Add(this.m_MainTab);
            this.m_AppTabControl.Controls.Add(this.m_FetchEventsTab);
            this.m_AppTabControl.Controls.Add(this.m_MutualLikedPagesTab);
            resources.ApplyResources(this.m_AppTabControl, "m_AppTabControl");
            this.m_AppTabControl.Name = "m_AppTabControl";
            this.m_AppTabControl.SelectedIndex = 0;
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
            resources.ApplyResources(this.m_MainTab, "m_MainTab");
            this.m_MainTab.Name = "m_MainTab";
            this.m_MainTab.UseVisualStyleBackColor = true;
            // 
            // m_SelectedLikedPagePictureBox
            // 
            this.m_SelectedLikedPagePictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.m_SelectedLikedPagePictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            this.m_SelectedLikedPagePictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.likepagepicDefault;
            resources.ApplyResources(this.m_SelectedLikedPagePictureBox, "m_SelectedLikedPagePictureBox");
            this.m_SelectedLikedPagePictureBox.Name = "m_SelectedLikedPagePictureBox";
            this.m_SelectedLikedPagePictureBox.TabStop = false;
            // 
            // m_RandomImagePictureBox
            // 
            resources.ApplyResources(this.m_RandomImagePictureBox, "m_RandomImagePictureBox");
            this.m_RandomImagePictureBox.Name = "m_RandomImagePictureBox";
            this.m_RandomImagePictureBox.TabStop = false;
            // 
            // m_FetchRandomPictureButton
            // 
            resources.ApplyResources(this.m_FetchRandomPictureButton, "m_FetchRandomPictureButton");
            this.m_FetchRandomPictureButton.Name = "m_FetchRandomPictureButton";
            this.m_FetchRandomPictureButton.UseVisualStyleBackColor = true;
            this.m_FetchRandomPictureButton.Click += new System.EventHandler(this.buttonFetchRandomPicture_Click);
            // 
            // m_SelectedGroupPictureBox
            // 
            this.m_SelectedGroupPictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.m_SelectedGroupPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.sports;
            this.m_SelectedGroupPictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.sports;
            resources.ApplyResources(this.m_SelectedGroupPictureBox, "m_SelectedGroupPictureBox");
            this.m_SelectedGroupPictureBox.Name = "m_SelectedGroupPictureBox";
            this.m_SelectedGroupPictureBox.TabStop = false;
            // 
            // m_SelectedAlbumPictureBox
            // 
            this.m_SelectedAlbumPictureBox.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.pictureaalbum;
            this.m_SelectedAlbumPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.pictureaalbum;
            this.m_SelectedAlbumPictureBox.InitialImage = global::BasicFacebookFeatures.Properties.Resources.pictureaalbum;
            resources.ApplyResources(this.m_SelectedAlbumPictureBox, "m_SelectedAlbumPictureBox");
            this.m_SelectedAlbumPictureBox.Name = "m_SelectedAlbumPictureBox";
            this.m_SelectedAlbumPictureBox.TabStop = false;
            // 
            // m_FetchGroupsButton
            // 
            resources.ApplyResources(this.m_FetchGroupsButton, "m_FetchGroupsButton");
            this.m_FetchGroupsButton.Name = "m_FetchGroupsButton";
            this.m_FetchGroupsButton.UseVisualStyleBackColor = true;
            this.m_FetchGroupsButton.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // m_FetchAlbumsButton
            // 
            resources.ApplyResources(this.m_FetchAlbumsButton, "m_FetchAlbumsButton");
            this.m_FetchAlbumsButton.Name = "m_FetchAlbumsButton";
            this.m_FetchAlbumsButton.UseVisualStyleBackColor = true;
            this.m_FetchAlbumsButton.Click += new System.EventHandler(this.buttonFetchAlbums_Click);
            // 
            // m_GroupsListBox
            // 
            this.m_GroupsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.m_GroupsListBox, "m_GroupsListBox");
            this.m_GroupsListBox.Name = "m_GroupsListBox";
            this.m_GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // m_AlbumsListBox
            // 
            this.m_AlbumsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.m_AlbumsListBox, "m_AlbumsListBox");
            this.m_AlbumsListBox.Name = "m_AlbumsListBox";
            this.m_AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // m_UpcomingBirthdayListBox
            // 
            this.m_UpcomingBirthdayListBox.FormattingEnabled = true;
            resources.ApplyResources(this.m_UpcomingBirthdayListBox, "m_UpcomingBirthdayListBox");
            this.m_UpcomingBirthdayListBox.Name = "m_UpcomingBirthdayListBox";
            // 
            // m_FetchUpcomingBirthdayButton
            // 
            resources.ApplyResources(this.m_FetchUpcomingBirthdayButton, "m_FetchUpcomingBirthdayButton");
            this.m_FetchUpcomingBirthdayButton.Name = "m_FetchUpcomingBirthdayButton";
            this.m_FetchUpcomingBirthdayButton.UseVisualStyleBackColor = true;
            this.m_FetchUpcomingBirthdayButton.Click += new System.EventHandler(this.buttonFetchUpcomingBirthdays_Click);
            // 
            // m_LikedPagesListBox
            // 
            this.m_LikedPagesListBox.FormattingEnabled = true;
            resources.ApplyResources(this.m_LikedPagesListBox, "m_LikedPagesListBox");
            this.m_LikedPagesListBox.Name = "m_LikedPagesListBox";
            this.m_LikedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // m_LikedPagesButton
            // 
            resources.ApplyResources(this.m_LikedPagesButton, "m_LikedPagesButton");
            this.m_LikedPagesButton.Name = "m_LikedPagesButton";
            this.m_LikedPagesButton.UseVisualStyleBackColor = true;
            this.m_LikedPagesButton.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // m_FetchPostsButton
            // 
            resources.ApplyResources(this.m_FetchPostsButton, "m_FetchPostsButton");
            this.m_FetchPostsButton.Name = "m_FetchPostsButton";
            this.m_FetchPostsButton.UseVisualStyleBackColor = true;
            this.m_FetchPostsButton.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // m_PostsListBox
            // 
            this.m_PostsListBox.FormattingEnabled = true;
            resources.ApplyResources(this.m_PostsListBox, "m_PostsListBox");
            this.m_PostsListBox.Name = "m_PostsListBox";
            // 
            // m_FetchEventsTab
            // 
            this.m_FetchEventsTab.Controls.Add(this.m_EventStatusComboBox);
            this.m_FetchEventsTab.Controls.Add(this.m_FetchEventButtons);
            this.m_FetchEventsTab.Controls.Add(this.m_EventGridView);
            resources.ApplyResources(this.m_FetchEventsTab, "m_FetchEventsTab");
            this.m_FetchEventsTab.Name = "m_FetchEventsTab";
            this.m_FetchEventsTab.UseVisualStyleBackColor = true;
            // 
            // m_EventStatusComboBox
            // 
            this.m_EventStatusComboBox.FormattingEnabled = true;
            this.m_EventStatusComboBox.Items.AddRange(new object[] {
            resources.GetString("m_EventStatusComboBox.Items"),
            resources.GetString("m_EventStatusComboBox.Items1"),
            resources.GetString("m_EventStatusComboBox.Items2")});
            resources.ApplyResources(this.m_EventStatusComboBox, "m_EventStatusComboBox");
            this.m_EventStatusComboBox.Name = "m_EventStatusComboBox";
            // 
            // m_FetchEventButtons
            // 
            resources.ApplyResources(this.m_FetchEventButtons, "m_FetchEventButtons");
            this.m_FetchEventButtons.Name = "m_FetchEventButtons";
            this.m_FetchEventButtons.UseVisualStyleBackColor = true;
            this.m_FetchEventButtons.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // m_EventGridView
            // 
            this.m_EventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.m_EventGridView, "m_EventGridView");
            this.m_EventGridView.Name = "m_EventGridView";
            this.m_EventGridView.RowTemplate.Height = 40;
            // 
            // m_MutualLikedPagesTab
            // 
            this.m_MutualLikedPagesTab.Controls.Add(this.m_CommonInterestListBox);
            this.m_MutualLikedPagesTab.Controls.Add(this.m_FetchCommonInterest);
            this.m_MutualLikedPagesTab.Controls.Add(this.m_LikePictureBox);
            resources.ApplyResources(this.m_MutualLikedPagesTab, "m_MutualLikedPagesTab");
            this.m_MutualLikedPagesTab.Name = "m_MutualLikedPagesTab";
            this.m_MutualLikedPagesTab.UseVisualStyleBackColor = true;
            // 
            // m_CommonInterestListBox
            // 
            this.m_CommonInterestListBox.FormattingEnabled = true;
            resources.ApplyResources(this.m_CommonInterestListBox, "m_CommonInterestListBox");
            this.m_CommonInterestListBox.Name = "m_CommonInterestListBox";
            // 
            // m_FetchCommonInterest
            // 
            resources.ApplyResources(this.m_FetchCommonInterest, "m_FetchCommonInterest");
            this.m_FetchCommonInterest.Name = "m_FetchCommonInterest";
            this.m_FetchCommonInterest.UseVisualStyleBackColor = true;
            this.m_FetchCommonInterest.Click += new System.EventHandler(this.buttonCommonInterest_Click);
            // 
            // m_LikePictureBox
            // 
            resources.ApplyResources(this.m_LikePictureBox, "m_LikePictureBox");
            this.m_LikePictureBox.Name = "m_LikePictureBox";
            this.m_LikePictureBox.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // m_HelloUserLabel
            // 
            resources.ApplyResources(this.m_HelloUserLabel, "m_HelloUserLabel");
            this.m_HelloUserLabel.Name = "m_HelloUserLabel";
            // 
            // m_UserProfilePicture
            // 
            this.m_UserProfilePicture.Image = global::BasicFacebookFeatures.Properties.Resources.FacebookLogo;
            resources.ApplyResources(this.m_UserProfilePicture, "m_UserProfilePicture");
            this.m_UserProfilePicture.Name = "m_UserProfilePicture";
            this.m_UserProfilePicture.TabStop = false;
            // 
            // checkBoxRememberUser
            // 
            resources.ApplyResources(this.checkBoxRememberUser, "checkBoxRememberUser");
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.m_HelloUserLabel);
            this.Controls.Add(this.m_UserProfilePicture);
            this.Controls.Add(this.m_LogoutButton);
            this.Controls.Add(this.m_AppTabControl);
            this.Controls.Add(this.m_LoginButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
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
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
    }
}

