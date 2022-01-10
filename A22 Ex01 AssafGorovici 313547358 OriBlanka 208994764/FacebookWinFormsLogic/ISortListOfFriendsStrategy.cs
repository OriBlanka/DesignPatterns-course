using System.Collections.Generic;

namespace FacebookWinFormsLogic
{
    public interface ISortListOfFriendsStrategy
    {
        void Sort(Dictionary<string, int> friendsList);
    }
}
