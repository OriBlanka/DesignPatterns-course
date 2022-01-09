using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsLogic
{
    class SortListOfFriendsByAscendingStrategy : ISortListOfFriendsStrategy
    {
        public void Sort(Dictionary<string, int> friendsList)
        {
            //Dictionary<string, int> sortedFreindsList = new Dictionary<string, int>();
            friendsList = (Dictionary<string, int>)from friend in friendsList orderby friend.Value ascending select friend;
          //  friendsList.Sort((a, b) => a.Value.CompareTo(b.Value));
        }
    }
}
