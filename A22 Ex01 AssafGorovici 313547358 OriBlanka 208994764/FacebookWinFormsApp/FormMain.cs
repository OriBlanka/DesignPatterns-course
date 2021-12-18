using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookWinFormsLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public enum eEventStatus
        {
            Online = 0,
            NotOnline = 1,
            AllEvents = 2
        }

        private readonly AppLogic r_AppLogic  = AppLogic.Instance;

        AppSettings m_AppSettings;
        LoginResult m_LoginResult;
        User m_LoggedInUser;
        private readonly Random r_Random = new Random();
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppLogic = new AppLogic();
            m_AppSettings = new AppSettings();
            m_AppSettings = AppSettings.FromFileOrDefault();
            this.StartPosition = FormStartPosition.Manual;
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = false;
            if (m_AppSettings.AutoLogin && !string.IsNullOrEmpty(m_AppSettings.AccessToken))
            {
             //   m_LoginResult = FacebookService.Connect(m_AppSettings.AccessToken);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppSettings.LastWindowState = this.WindowState;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.AutoLogin = this.checkBoxRememberUser.Checked;
            m_AppSettings.AccessToken = this.checkBoxRememberUser.Checked ? m_AppSettings.AccessToken : null;
            

            if (this.checkBoxRememberUser.Checked)
            {
                m_AppSettings.Save();
            }
            else
            {
                AppSettings.DeleteSettingsFile();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Size = m_AppSettings.LastWindowSize;
            this.WindowState = m_AppSettings.LastWindowState;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.AutoLogin;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_AppSettings.AutoLogin)
            {
                autoLogin();
            }
        }

        private void autoLogin()
        {
            //  m_LoginResult = FacebookService.Connect(m_AppSettings.AccessToken);
            m_LoginResult = FacebookService.Connect(m_AppSettings.AccessToken);
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            fetchUserInfo();
            
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20aa"); 
            r_AppLogic.LoginAndLoadUserInfo(ref m_AppSettings);
            m_LoggedInUser = r_AppLogic.LoggedUser;
            displayUserInfoAfterLogin();
        }

        private void displayUserInfoAfterLogin()
        {
            if(!string.IsNullOrEmpty(r_AppLogic.LoginResult.AccessToken))
            {
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(r_AppLogic.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            m_UserProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            m_HelloUserLabel.Text = $@"Hi {m_LoggedInUser.FirstName}!";
            m_LoginButton.Text = $@"Logged in as {m_LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoginButton.Text = "Login";
            m_HelloUserLabel.Text = "";
            m_UserProfilePicture.Image = Properties.Resources.FacebookLogo;
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            m_FetchPostsButton.Enabled = false;
            fetchPost();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Event> allEvents = r_AppLogic.LoggedUser.Events;
            FacebookObjectCollection<Event> sortedEvents = new FacebookObjectCollection<Event>();

            switch (m_EventStatusComboBox.SelectedIndex)
            {
                case (int)eEventStatus.Online:
                    fetchEvents(ref allEvents, ref sortedEvents, true);
                    break;

                case (int)eEventStatus.NotOnline:
                    fetchEvents(ref allEvents, ref sortedEvents, false);
                    break;

                case (int)eEventStatus.AllEvents:
                    sortedEvents = allEvents;
                    break;
            }

            m_EventGridView.DataSource = sortedEvents;
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Page> likedPages = r_AppLogic.LoggedUser.LikedPages;
            m_LikedPagesListBox.Items.Clear();
            m_LikedPagesListBox.DisplayMember = "Name";
            fillListBoxes(likedPages, m_LikedPagesListBox);
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Album> albums = r_AppLogic.LoggedUser.Albums;
            m_AlbumsListBox.Items.Clear();
            fillListBoxes(albums, m_AlbumsListBox);
        }

        private void buttonFetchUpcomingBirthdays_Click(object sender, EventArgs e)
        {
            bool areFriendsBDaysThisMonth = false;
            foreach(User friend in r_AppLogic.LoggedUser.Friends)

            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday);
                if(friendBirthday.Month == DateTime.Now.Month)
                {
                    areFriendsBDaysThisMonth = true;
                    m_UpcomingBirthdayListBox.Items.Add($"{friend.Name} - {friend.Birthday} ");
                }
            }

            if(!areFriendsBDaysThisMonth)
            {
                m_UpcomingBirthdayListBox.Items.Add($"No friends birthdays on {DateTime.Now:M}");
            }
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        { 
            FacebookObjectCollection<Group> favoriteTeams = r_AppLogic.LoggedUser.Groups;
            m_GroupsListBox.Items.Clear();
            fillListBoxes(favoriteTeams, m_GroupsListBox);
        }

        private void buttonFetchRandomPicture_Click(object sender, EventArgs e)
        {
            try
            {
                m_RandomImagePictureBox.Image =getRandomImage();
            }
            catch (Exception pictureException)
            {
                MessageBox.Show($@"An error occurred with the facebook API: {Environment.NewLine} {pictureException.Message}");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedLikedPage();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedGroup();
        }

        private void buttonCommonInterest_Click(object sender, EventArgs e)
        {

            new Thread(fetchFriendsWithCommonInterest).Start();
        }

        private void displaySelectedAlbum()
        {
            if (m_AlbumsListBox.SelectedItems.Count == 1)
            {
                Album selectedAlbum = m_AlbumsListBox.SelectedItem as Album;
                showCurrentItemPicture(m_SelectedAlbumPictureBox, selectedAlbum.PictureAlbumURL);
            }
        }

        private void displaySelectedLikedPage()
        {
            if (m_LikedPagesListBox.SelectedItems.Count == 1)
            {
                Page selectedPage = m_LikedPagesListBox.SelectedItem as Page;
                showCurrentItemPicture(m_SelectedLikedPagePictureBox, selectedPage.PictureURL);
            }
        }

        private void displaySelectedGroup()
        {
            if (m_GroupsListBox.SelectedItems.Count == 1)
            {
                Page selectedFavoriteTeam = m_GroupsListBox.SelectedItem as Page;
                showCurrentItemPicture(m_SelectedGroupPictureBox, selectedFavoriteTeam.PictureURL);
            }
        }

        private void fetchPost()
        {
            FacebookObjectCollection<Post> myPosts = r_AppLogic.LoggedUser.Posts;
            m_PostsListBox.Items.Clear();

            foreach (Post post in myPosts)
            {
                if (post.Message != null)
                {
                    m_PostsListBox.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    m_PostsListBox.Items.Add(post.Caption);
                }
                else
                {
                    m_PostsListBox.Items.Add($"[{post.Type}]");
                }
            }

            if (m_PostsListBox.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchFriendsWithCommonInterest()
        {
            bool isFriendWithCommonInterest = false;
            Dictionary<string, int> friendsCommonPagesLikes = new Dictionary<string, int>();
            getFriendsCommonInterest(ref friendsCommonPagesLikes, ref isFriendWithCommonInterest);

            foreach (KeyValuePair<string, int> friendInDictionary in friendsCommonPagesLikes)
            {
                m_CommonInterestListBox.Invoke(new Action(() => m_CommonInterestListBox.Items.Add($"{friendInDictionary.Key} - {friendInDictionary.Value.ToString()} Pages")));
            }

            if (!isFriendWithCommonInterest)
            {
                m_CommonInterestListBox.Invoke(new Action(() => m_CommonInterestListBox.Items.Add("No Friends With Common Liked Pages")));
            }
        }

        private void fillListBoxes<T>(FacebookObjectCollection<T> i_FacebookItemsCollection, ListBox io_FacebookItemsList)
        {
            try
            {
                foreach(T item in i_FacebookItemsCollection)
                {
                    io_FacebookItemsList.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            if(io_FacebookItemsList.Items.Count == 0)
            {
                io_FacebookItemsList.Items.Add("No liked pages to retrieve :(");
            }
        }

        private void showCurrentItemPicture(PictureBox io_ItemPicture, string i_ItemPictureURL)
        {
            if (!string.IsNullOrEmpty(i_ItemPictureURL))
            {
                io_ItemPicture.LoadAsync(i_ItemPictureURL);
            }
            else
            {
                io_ItemPicture.Image = io_ItemPicture.ErrorImage;
            }
        }

        private void fetchEvents(ref FacebookObjectCollection<Event> i_Events, ref FacebookObjectCollection<Event> io_sortedEvents, bool i_IsOnline)
        {
            if (i_IsOnline)
            {
                foreach (Event events in i_Events)
                {
                    if (events.IsOnline != null && (bool)events.IsOnline)
                    {
                        io_sortedEvents.Add(events);
                    }
                }
            }
            else
            {
                foreach (Event events in i_Events)
                {
                    if (events.IsOnline != null && (bool)!events.IsOnline)
                    {
                        io_sortedEvents.Add(events);
                    }
                }
            }
        }

        private Image getRandomImage()
        {
            FacebookObjectCollection<Photo> taggedPictures = r_AppLogic.LoggedUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }

        private void getFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest)
        {
            foreach (User friend in r_AppLogic.LoggedUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (Page friendLikedPage in friend.LikedPages)
                {
                    if (r_AppLogic.LoggedUser.LikedPages.Contains(friendLikedPage))
                    {
                        io_IsFriendWithCommonInterest = true;
                        friendCommonLikedPages++;
                    }
                }

                if (friendCommonLikedPages > 0)
                {
                    io_FriendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
                }
            }
        }
    }
}
