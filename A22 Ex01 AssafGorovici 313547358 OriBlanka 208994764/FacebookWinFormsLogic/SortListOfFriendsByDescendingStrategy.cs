using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsLogic
{
    class SortListOfFriendsByDescendingStrategy : ISortListOfFriendsStrategy
    {
        public void Sort(Dictionary<string, int> friendsList)
        {
            friendsList = (Dictionary<string, int>)from friend in friendsList orderby friend.Value descending select friend;
            //friendsList.Sort((a, b) => b.CompareTo(a));
        }
    }
}
