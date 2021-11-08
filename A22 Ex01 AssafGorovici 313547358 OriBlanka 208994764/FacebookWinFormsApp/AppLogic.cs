using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public AppLogic()
        {
            
        }

        public User LoggedInUser 
        { 
            get => m_LoggedInUser;
            set => m_LoggedInUser = value;
        }

        public LoginResult LoginResult { get; set; }

        public void LoginAndLoadUserInfo()
        {
            LoginResult = FacebookService.Login("4722021931181899", 
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

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                m_LoggedInUser = LoginResult.LoggedInUser;
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

        public void FetchVideo(ref FacebookObjectCollection<Video> io_Videos)
        {
            foreach (Video video in m_LoggedInUser.Videos)
            {
                io_Videos.Add(video);
            }
        }

        public void FetchAlbums(ref FacebookObjectCollection<Album> io_Albums)
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                io_Albums.Add(album);
            }
        }
        
        //Todo - From any reason this method doesn't work
        public void FetchGroups(ref FacebookObjectCollection<Group> io_Groups)
        {
            foreach (Group group in m_LoggedInUser.Groups)
            {
                io_Groups.Add(group);
            }
        }

        //Todo - Think on option that the user hasn't favorite teams - we getting null exception
        public void FetchFavoriteTeams(ref FacebookObjectCollection<Page> io_FavoriteTeams)
        {
            foreach (Page team in m_LoggedInUser.FavofriteTeams)
            {
                io_FavoriteTeams.Add(team);
            }
        }

        //Todo: Doesn't success while trying to get friend list
        public void FetchFriends(ref FacebookObjectCollection<FriendList> io_Friends)
        {
            foreach (FriendList friend in m_LoggedInUser.FriendLists)
            {
                io_Friends.Add(friend);
            }
        }

        public void FetchEvents(ref FacebookObjectCollection<Event> i_Events, ref FacebookObjectCollection<Event> io_sortedEvents, bool i_IsOnline)
        {
            if(i_IsOnline)
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
    }
}
