using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    interface ISorterStrategy
    {
        FacebookObjectCollection<User> SortCollection();
    }

    public enum eFriendsSortType
    {
        AgeASC = 1,
        AgeDEC,
        Male,
        Female
    }
}
