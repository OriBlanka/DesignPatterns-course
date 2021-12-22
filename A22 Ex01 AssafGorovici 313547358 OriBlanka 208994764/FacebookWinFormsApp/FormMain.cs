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
    //Todo - need to change this class in order to use the relevant methods in the interface and in the proxy class
    //Todo - need to make change in the login (new class was added and it caused to changes in the login process too)
    public partial class FormMain : Form
    {
        public enum eEventStatus
        {
            Online = 0,
            NotOnline = 1,
            AllEvents = 2
        }

        private readonly AppLogic r_AppLogic  = AppLogic.Instance;
        private IFacebookUser LoggedUser { get; set; }

        public bool IsLoggedIn { get; set; }

        private readonly AppSettings r_AppSettings;
        LoginResult m_LoginResult;
        private const string k_AppId = "4722021931181899";
        private readonly Random r_Random = new Random();
        private bool loggedIn;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.FromFileOrDefault();
            this.StartPosition = FormStartPosition.Manual;
            this.Size = r_AppSettings.LastWindowSize;
            this.Location = r_AppSettings.LastWindowLocation;
            this.m_checkBoxRememberUser.Checked = false;
            LoggedUser = r_AppLogic.GetUser();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            r_AppSettings.LastWindowState = this.WindowState;
            r_AppSettings.LastWindowSize = this.Size;
            r_AppSettings.LastWindowLocation = this.Location;
            r_AppSettings.AutoLogin = this.m_checkBoxRememberUser.Checked;
            r_AppSettings.AccessToken = m_checkBoxRememberUser.Checked ? r_AppLogic.AccessToken : null;

            if (this.m_checkBoxRememberUser.Checked)
            {
                r_AppSettings.Save();
            }
            else
            {
                AppSettings.DeleteSettingsFile();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Size = r_AppSettings.LastWindowSize;
            this.WindowState = r_AppSettings.LastWindowState;
            this.Location = r_AppSettings.LastWindowLocation;
            this.m_checkBoxRememberUser.Checked = r_AppSettings.AutoLogin;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (r_AppSettings.AutoLogin)
            {
                autoLogin();
            }
        }

        private void autoLogin()
        {
            loggedIn = true;
            r_AppLogic.Connect(r_AppSettings.AccessToken, k_AppId, ref loggedIn);
            //r_AppLogic.Connect("EABDGp2fUZA0sBAAKoVjWA0tgCNhqW8cctAKfRLrPMs7MwHqDDNTZCoOLYMeVf7wOcxCZAHoLrJoyPpMToHjd8iiB72hdJm4LnveIFXmd1V2CxLWO7pnjRIbmKiezdevZATfw3iZBQe9sN4r2n3gXkuwI0lF2BGjwrkHjC6nQCHQZDZD", k_AppId, ref loggedIn);
            LoggedUser = r_AppLogic.GetUser();
            //m_LoginResult = FacebookService.Connect(r_AppSettings.AccessToken);
            fetchUserInfo();
            
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loggedIn = false;
                r_AppLogic.Connect(r_AppSettings.AccessToken, k_AppId, ref loggedIn);
                LoggedUser = r_AppLogic.GetUser();
                IsLoggedIn = loggedIn;
                displayUserInfoAfterLogin();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error occurred!
Try again please :)");
            }
        }

        private void displayUserInfoAfterLogin()
        {
            if(!string.IsNullOrEmpty(r_AppLogic.AccessToken))
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
            m_UserProfilePicture.Image = LoggedUser.GetImageSmall();
            m_HelloUserLabel.Text = $@"Hi {LoggedUser.GetFirstName()}!";
            m_LoginButton.Text = $@"Logged in as {LoggedUser.GetFirstName()} {LoggedUser.GetLastName()}";
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
            FacebookObjectCollection<Event> allEvents = LoggedUser.GetLEvents();
            FacebookObjectCollection<Event> sortedEvents = new FacebookObjectCollection<Event>();

            switch (m_EventStatusComboBox.SelectedIndex)
            {
                case (int)eEventStatus.Online:
                    LoggedUser.GetEventsSorted(ref allEvents, ref sortedEvents, true);
                    break;

                case (int)eEventStatus.NotOnline:
                    LoggedUser.GetEventsSorted(ref allEvents, ref sortedEvents, false);
                    break;

                case (int)eEventStatus.AllEvents:
                    sortedEvents = allEvents;
                    break;
            }
            //fillListBoxes(sortedEvents, m_FetchEventsListBox);
            m_EventGridView.DataSource = sortedEvents;
            eventBindingSource.DataSource = sortedEvents;
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

            //Todo - Check what we need to do with the NullException that we get
            LoggedUser.GetFriendsCommonInterest(ref friendsCommonPagesLikes, ref isFriendWithCommonInterest);
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
    }
}
