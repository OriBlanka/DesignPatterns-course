using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

//Todo - need to add more methods according to the features that we have in FormMain
public interface IFacebookUser
{
    string GetFirstName();

    string GetLastName();

    Image GetImageSmall();

    void GetEventsSorted(ref FacebookObjectCollection<Event> i_Events, ref FacebookObjectCollection<Event> io_sortedEvents, bool i_IsOnline);

    FacebookObjectCollection<Event> GetAllEvents();

    FacebookObjectCollection<Page> GetLikedPages();

    FacebookObjectCollection<User> GetFriends();

    FacebookObjectCollection<Post> GetPosts();

    FacebookObjectCollection<Album> GetAlbums();

    FacebookObjectCollection<Group> GetFavoriteTeams();

    FacebookObjectCollection<Photo> GetPhotosTaggedIn();

    void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest);

}

