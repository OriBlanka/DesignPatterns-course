using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

public interface IFacebookUser
{
    string GetFirstName();

    string GetLastName();

    Image GetImageSmall();

    FacebookObjectCollection<Event> GetEvents();

    FacebookObjectCollection<Page> GetLikedPages();

    FacebookObjectCollection<User> GetFriends();

    void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest);

}

