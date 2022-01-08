using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsLogic
{
    public interface ISortListOfFriendsStrategy
    {
        void Sort(List<string> friendsList);
    }
}
