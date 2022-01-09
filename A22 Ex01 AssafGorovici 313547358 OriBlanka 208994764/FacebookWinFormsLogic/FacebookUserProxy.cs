using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class FacebookUserProxy : IFacebookUser
    {
        private readonly User r_FacebookUser;
        private readonly  PhotoSelectionAlgorithmBase r_PhotoSelectionAlgorithm = new PhotoRandomizer();
        private ISortListOfFriendsStrategy m_SortListOfFriendsStrategy;

        public FacebookUserProxy(User i_User)
        {
            r_FacebookUser = i_User;
        }

        public string GetFirstName()
        {
            return r_FacebookUser.FirstName;
        }

        public string GetLastName()
        {
            return r_FacebookUser.LastName;
        }

        public Image GetImageSmall()
        {
            return r_FacebookUser.ImageSmall;
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return r_FacebookUser.Posts;
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return r_FacebookUser.Albums;
        }

        public FacebookObjectCollection<Group> GetFavoriteTeams()
        {
            return r_FacebookUser.Groups;
        }

        public FacebookObjectCollection<Event> GetAllEvents()
        {
            return r_FacebookUser.Events;
        }

        public Image GetSelectedImage()
        {
            return r_PhotoSelectionAlgorithm.GetPhoto(r_FacebookUser);
        }

        public void GetEventsSorted(ref FacebookObjectCollection<Event> i_Events, ref FacebookObjectCollection<Event> io_sortedEvents, bool i_IsOnline)
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

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return r_FacebookUser.LikedPages;
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return r_FacebookUser.Friends;
        }

        public void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest, string i_SortBy)
        {
            foreach (User friend in r_FacebookUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (Page friendLikedPage in friend.LikedPages)
                {
                    if (r_FacebookUser.LikedPages.Contains(friendLikedPage))
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

            setSortStrategy(i_SortBy);
            m_SortListOfFriendsStrategy.Sort(io_FriendsCommonPagesLikes);

        }

        private void setSortStrategy(string i_SortBy)
        {
            switch (i_SortBy)
            {
                case "Ascending":
                    m_SortListOfFriendsStrategy = new SortListOfFriendsByAscendingStrategy();
                    break;
                case "Descending":
                    m_SortListOfFriendsStrategy = new SortListOfFriendsByDescendingStrategy();
                    break;
                default:
                    m_SortListOfFriendsStrategy = new SortListOfFriendsByAscendingStrategy();
                    break;
            }
        }
    }
}
