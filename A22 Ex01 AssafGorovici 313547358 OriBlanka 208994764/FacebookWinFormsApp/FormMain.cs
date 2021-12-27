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
using System.Net;
using System.IO;
using System.Globalization;

namespace BasicFacebookFeatures
{
    //Todo - need to continue to implement multi-threading
    public partial class FormMain : Form
    {
        public enum eEventStatus
        {
            Online = 0,
            NotOnline = 1,
            AllEvents = 2
        }

        private bool m_LoggedIn;
        private const string k_AppId = "4722021931181899";
        private readonly AppSettings r_AppSettings;
        private readonly Random r_Random = new Random();
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
  
        private readonly NasaFacade r_NasaFacade = new NasaFacade();

        private IFacebookUser LoggedUser { get; set; }

        public bool IsLoggedIn { get; set; }

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
            m_LoggedIn = true;
            r_AppLogic.Connect(r_AppSettings.AccessToken, k_AppId, ref m_LoggedIn);
            LoggedUser = r_AppLogic.GetUser();
            fetchUserInfo();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedIn = false;
                r_AppLogic.Connect(r_AppSettings.AccessToken, k_AppId, ref m_LoggedIn);
                LoggedUser = r_AppLogic.GetUser();
                IsLoggedIn = m_LoggedIn;
                fetchUserInfo();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"Error occurred!
Try again please :)");
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
            new Thread(fetchPost).Start();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            m_LikedPagesButton.Enabled = false;
            new Thread(fetchLikedPages).Start();
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            m_FetchAlbumsButton.Enabled = false;
            new Thread(fetchAlbums).Start();
            
        }

        private void buttonFetchUpcomingBirthdays_Click(object sender, EventArgs e)
        {
            m_FetchUpcomingBirthdayButton.Enabled = false;
            new Thread(fetchUpcomingBirthday).Start();
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            m_FetchGroupsButton.Enabled = false;
            new Thread(fetchGroups).Start();
            
        }

        private void buttonFetchRandomPicture_Click(object sender, EventArgs e)
        {
            new Thread(fetchRandomPicture).Start();
        }

        private void buttonCommonInterest_Click(object sender, EventArgs e)
        {
            new Thread(fetchFriendsWithCommonInterest).Start();
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
            FacebookObjectCollection<Post> myPosts = LoggedUser.GetPosts();

            foreach (Post post in myPosts)
            {
                if (post.Message != null)
                {
                    m_PostsListBox.Invoke(new Action(() => m_PostsListBox.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    m_PostsListBox.Invoke(new Action(() => m_PostsListBox.Items.Add(post.Caption)));
                }
                else
                {
                    m_PostsListBox.Invoke(new Action(() => m_PostsListBox.Items.Add($"[{post.Type}]")));
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

        private void fetchEvents()
        {
            FacebookObjectCollection<Event> allEvents = LoggedUser.GetAllEvents();
            FacebookObjectCollection<Event> sortedEvents = new FacebookObjectCollection<Event>();
            object comboBoxSelectedIndex =
                m_EventStatusComboBox.Invoke(new Action(() => 
                    {
                        comboBoxSelectedIndex = m_EventStatusComboBox.SelectedIndex;
                    }));

            switch(comboBoxSelectedIndex)
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

            if (sortedEvents.Count == 0)
            {
                MessageBox.Show("No events to retrieve :(");
            }

            eventBindingSource.DataSource = sortedEvents;
        }

        private void fetchLikedPages()
        {
            FacebookObjectCollection<Page> likedPages = LoggedUser.GetLikedPages();
            m_LikedPagesListBox.DisplayMember = "Name";
            fillListBoxes(likedPages, m_LikedPagesListBox);
        }

        private void fetchAlbums()
        {
            FacebookObjectCollection<Album> albums = LoggedUser.GetAlbums();
            m_AlbumsListBox.DisplayMember = "Name";
            fillListBoxes(albums, m_AlbumsListBox);
        }

        private void fetchUpcomingBirthday()
        {
            bool areFriendsBDaysThisMonth = false;
            foreach (User friend in LoggedUser.GetFriends())

            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday);
                if (friendBirthday.Month == DateTime.Now.Month)
                {
                    areFriendsBDaysThisMonth = true;
                    m_UpcomingBirthdayListBox.Invoke(new Action(() => m_UpcomingBirthdayListBox.Items.Add($"{friend.Name} - {friend.Birthday} ")));
                }
            }

            if (!areFriendsBDaysThisMonth)
            {
                m_UpcomingBirthdayListBox.Invoke(new Action(() => m_UpcomingBirthdayListBox.Items.Add($"No friends birthdays on {DateTime.Now:M}")));
            }
        }

        private void fetchGroups()
        {
            m_GroupsListBox.DisplayMember = "Name";
            FacebookObjectCollection<Group> favoriteTeams = LoggedUser.GetFavoriteTeams();
            fillListBoxes(favoriteTeams, m_GroupsListBox);
        }

        private void fetchRandomPicture()
        {
            try
            {
                m_RandomImagePictureBox.Image = getRandomImage();
            }
            catch (Exception pictureException)
            {
                MessageBox.Show($@"An error occurred with the facebook API: {Environment.NewLine} {pictureException.Message}");
            }
        }

        private void fillListBoxes<T>(FacebookObjectCollection<T> i_FacebookItemsCollection, ListBox io_FacebookItemsList)
        {
            try
            {
                foreach (T item in i_FacebookItemsCollection)
                {
                    io_FacebookItemsList.Invoke(new Action(() => io_FacebookItemsList.Items.Add(item)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (io_FacebookItemsList.Items.Count == 0)
            {
                io_FacebookItemsList.Invoke(new Action(() => io_FacebookItemsList.Items.Add("No liked pages to retrieve :(")));
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
        
        private Image getRandomImage()
        {
            FacebookObjectCollection<Photo> taggedPictures = LoggedUser.GetPhotosTaggedIn();
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }

        
        private void m_getNasaPicTodayButton_Click(object sender, EventArgs e)
        {
            string response = r_NasaFacade.GetNasaPicOfTheDay();
            response.Replace("url", "");
            //Todo - need to make changes in the names of the variable and think 
            string[] subs = response.Split(',');
            int lastcell = subs.Length - 1;
            subs[lastcell] = subs[lastcell].Substring(7);
            subs[lastcell] = subs[lastcell].Remove(subs[lastcell].Length - 3);
            showCurrentItemPicture(m_NasaPicByTodaypictureBox, $"{subs[lastcell]}");
        }

        private void m_GetNasaPictureByDatebutton_Click(object sender, EventArgs e)
        {
            DateTime date = m_NasaDateTimePicker.Value;
            string dateString = date.ToString("d", CultureInfo.CreateSpecificCulture("ja-JP"));
            dateString = dateString.Replace('/', '-');
            string response = r_NasaFacade.GetNasaPicBYDate(dateString);
            response.Replace("url", "");
            string[] subs = response.Split(',');
            int lastcell = subs.Length - 1;
            subs[lastcell] = subs[lastcell].Substring(7);
            subs[lastcell] = subs[lastcell].Remove(subs[lastcell].Length - 3);
            showCurrentItemPicture(m_NasaPicByDatepictureBox, $"{subs[lastcell]}");
            
        }
    }
}
