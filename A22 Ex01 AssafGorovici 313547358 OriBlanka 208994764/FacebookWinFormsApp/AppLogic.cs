using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class AppLogic
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public AppLogic()
        {
            
        }
        public User LoggedInUser {
            get { return m_LoggedInUser; }

            set { m_LoggedInUser = value; }
        }

        public LoginResult LoginResult
        {
            get { return m_LoginResult; }

            set { m_LoginResult = value; }
        }
        public void loginAndLoadUserInfo()
        {
            m_LoginResult = FacebookService.Login("4722021931181899", /// (desig patter's "Design Patterns Course App 2.4" app)
					"email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                
            }
           

        }

        public void FetchLikedPages(ref FacebookObjectCollection<Page> io_LikedPages)
        {
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                io_LikedPages.Add(page);
            }
        }

        public void FetchPosts(ref FacebookObjectCollection<Post> io_Posts)
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                io_Posts.Add(post);
            }
        }

        public void FetchAlbums(ref FacebookObjectCollection<Album> io_Albums)
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                io_Albums.Add(album);
            }
        }

        public void FetchGroups(ref FacebookObjectCollection<Group> io_Groups)
        {
            foreach (Group group in m_LoggedInUser.Groups)
            {
                io_Groups.Add(group);
            }
        }

        public void FetchFavoriteTeams(ref FacebookObjectCollection<Page> io_FavoriteTeams)
        {
            foreach (Page team in m_LoggedInUser.FavofriteTeams)
            {
                io_FavoriteTeams.Add(team);
            }
        }

        public void FetchFriends(ref FacebookObjectCollection<FriendList> io_Friends)
        {
            io_Friends = m_LoggedInUser.FriendLists;
        }

    }
}
