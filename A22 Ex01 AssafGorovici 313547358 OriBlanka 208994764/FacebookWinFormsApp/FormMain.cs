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
        
        private readonly AppLogic r_AppLogic;
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppLogic = new AppLogic();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            r_AppLogic.loginAndLoadUserInfo();
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

            foreach (Post post in myPosts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Event> actions = r_AppLogic.LoggedInUser.Events;

            dataGridViewEvents.DataSource = actions;
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
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Group> groups = new FacebookObjectCollection<Group>();
            r_AppLogic.FetchGroups(ref groups);

            listBoxGroups.Items.Clear();

            foreach (Group group in groups)
            {
                listBoxGroups.Items.Add(group);
            }
        }

        private void buttonFetchFavoriteTeams_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<Page> favoriteTeams = new FacebookObjectCollection<Page>();

            listBoxFavoriteTeams.Items.Clear();

            foreach (Page team in favoriteTeams)
            {
                listBoxFavoriteTeams.Items.Add(team);
            }
        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            FacebookObjectCollection<FriendList> friendLists = new FacebookObjectCollection<FriendList>();

            listBoxFriends.Items.Clear();

            r_AppLogic.FetchFriends(ref friendLists);

            
        }
    }


}
