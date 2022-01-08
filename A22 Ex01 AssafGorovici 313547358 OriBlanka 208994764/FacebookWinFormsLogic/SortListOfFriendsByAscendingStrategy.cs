using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsLogic
{
    class SortListOfFriendsByAscendingStrategy : ISortListOfFriendsStrategy
    {
        public void Sort(List<string> friendsList)
        {
            friendsList.Sort((a, b) => a.CompareTo(b));
        }
    }
}
