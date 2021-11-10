using System;
using System.Collections.Generic;
using System.Drawing;
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
        public User LoggedUser { get; set; }

        public LoginResult LoginResult { get; set; }

        private readonly Random r_Random = new Random();

        public AppLogic()
        {
            
        }

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
                LoggedUser = LoginResult.LoggedInUser;
            }
        }

        public void FetchPosts(ref FacebookObjectCollection<Post> io_Posts)
        {
            foreach (Post post in LoggedUser.Posts)
            {
                io_Posts.Add(post);
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

        public Image GetRandomImage()
        {
            FacebookObjectCollection<Photo> taggedPictures = LoggedUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }

        public void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest)
        {
            foreach (User friend in LoggedUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (Page friendLikedPage in friend.LikedPages)
                {
                    if (LoggedUser.LikedPages.Contains(friendLikedPage))
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
