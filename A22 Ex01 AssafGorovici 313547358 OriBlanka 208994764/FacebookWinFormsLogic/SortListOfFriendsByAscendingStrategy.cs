using System.Collections.Generic;
using System.Linq;

namespace FacebookWinFormsLogic
{
    public class SortListOfFriendsByAscendingStrategy : ISortListOfFriendsStrategy
    {
        public void Sort(Dictionary<string, int> friendsList)
        {
            
            var friendsKeyValueList = from friend in friendsList orderby friend.Value ascending select friend;
            friendsList = friendsKeyValueList.ToDictionary(x => x.Key, x => x.Value);

        }
    }
}
