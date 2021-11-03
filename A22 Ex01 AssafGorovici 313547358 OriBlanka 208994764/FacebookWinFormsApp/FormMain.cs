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
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in r_AppLogic.LoggedInUser.Posts)
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
    }


}
