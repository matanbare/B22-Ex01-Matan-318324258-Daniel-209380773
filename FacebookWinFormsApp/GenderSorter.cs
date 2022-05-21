using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class GenderSorter : ISorterStrategy
    {
        private FacebookObjectCollection<User> UserFriends { get; }

        private User.eGender GenderToSort { get; }

        public GenderSorter(FacebookObjectCollection<User> i_UserFriends, User.eGender i_GenderToSort)
        {
            UserFriends = i_UserFriends;
            GenderToSort = i_GenderToSort;
        }

        public FacebookObjectCollection<User> SortCollection()
        {
            FacebookObjectCollection<User> upToDateFriendList = new FacebookObjectCollection<User>();

            foreach (var friend in UserFriends)
            {
                if (friend.Gender == GenderToSort)
                {
                    upToDateFriendList.Add(friend);
                }
            }

            return upToDateFriendList;
        }
    }
}
