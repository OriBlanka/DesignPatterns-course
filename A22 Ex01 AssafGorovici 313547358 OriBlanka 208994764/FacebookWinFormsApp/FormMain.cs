using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

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

        private readonly AppLogic r_AppLogic;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppLogic = new AppLogic();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20aa"); /// the current password for Desig Patter
            r_AppLogic.LoginAndLoadUserInfo();
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
            m_UserProfilePicture.LoadAsync(r_AppLogic.LoggedInUser.PictureNormalURL);
            m_HelloUserLabel.Text = $@"Hi {r_AppLogic.LoggedInUser.FirstName}!";
            buttonLogin.Text = $@"Logged in as {r_AppLogic.LoggedInUser.Name}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            m_HelloUserLabel.Text = "";
            m_UserProfilePicture.Image = Properties.Resources.FacebookLogo;
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Post> myPosts = new FacebookObjectCollection<Post>();
            r_AppLogic.FetchPosts(ref myPosts);
            listBoxPosts.Items.Clear();

            foreach(Post post in myPosts)
            {
                if(post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if(post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if(listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Event> allEvents = r_AppLogic.LoggedInUser.Events;
            FacebookObjectCollection<Event> sortedEvents = new FacebookObjectCollection<Event>();

            switch (comboBoxEventsStatus.SelectedIndex)
            {
                case (int)eEventStatus.Online:
                    r_AppLogic.FetchEvents(ref allEvents, ref sortedEvents, true);
                    break;

                case (int)eEventStatus.NotOnline:
                    r_AppLogic.FetchEvents(ref allEvents, ref sortedEvents, false);
                    break;

                case (int)eEventStatus.AllEvents:
                    sortedEvents = allEvents;
                    break;
            }

            dataGridViewEvents.DataSource = sortedEvents;
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Page> likedPages = new FacebookObjectCollection<Page>();
            r_AppLogic.FetchLikedPages(ref likedPages);
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in likedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }

            pictureBoxSelectedLikedPage.Image = pictureBoxSelectedLikedPage.InitialImage;
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Album> albums = new FacebookObjectCollection<Album>();
            r_AppLogic.FetchAlbums(ref albums);
            listBoxAlbums.Items.Clear();

            foreach (Album album in albums)
            {
                listBoxAlbums.Items.Add(album);
            }

            pictureBoxSelectedAlbum.Image = pictureBoxSelectedAlbum.InitialImage;
        }

        private void buttonFetchUpcomingBirthdays_Click(object sender, EventArgs e)
        {
            bool areFriendsBDaysThisMonth = false;

            foreach (User friend in r_AppLogic.LoggedInUser.Friends)

            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday);
                if (friendBirthday.Month == DateTime.Now.Month)
                {
                    areFriendsBDaysThisMonth = true;
                    listBoxUpcomingBirthdays.Items.Add($"{friend.Name} - {friend.Birthday} ");
                }
            }

            if (!areFriendsBDaysThisMonth)
            {
                listBoxUpcomingBirthdays.Items.Add($"No friends birthdays on {DateTime.Now:M}");
            }
        }

        private void buttonFetchFavoriteTeams_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Page> favoriteTeams = new FacebookObjectCollection<Page>();
            r_AppLogic.FetchFavoriteTeams(ref favoriteTeams);
            listBoxFavoriteTeams.Items.Clear();
            Page selectedFavoriteTeam = listBoxFavoriteTeams.SelectedItem as Page;

            foreach (Page team in favoriteTeams)
            {
                listBoxFavoriteTeams.Items.Add(team);
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
           


        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxSelectedAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxSelectedAlbum.Image = pictureBoxSelectedAlbum.ErrorImage;
                }
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedLikedPage();
        }

        private void displaySelectedLikedPage()
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                if (selectedPage.PictureURL != null)
                {
                    pictureBoxSelectedLikedPage.LoadAsync(selectedPage.PictureURL);
                }
                else
                {
                    pictureBoxSelectedLikedPage.Image = pictureBoxSelectedLikedPage.ErrorImage;
                }
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFavoriteTeam();
        }

        private void displaySelectedFavoriteTeam()
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedFavoriteTeam = listBoxFavoriteTeams.SelectedItem as Page;
                if (selectedFavoriteTeam.PictureURL != null)
                {
                    pictureBoxSelectedFavoriteTeam.LoadAsync(selectedFavoriteTeam.PictureURL);
                }
                else
                {
                    pictureBoxSelectedFavoriteTeam.Image = pictureBoxSelectedFavoriteTeam.ErrorImage;
                }
            }
        }
    }
}
