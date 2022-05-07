using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.DevTools.Page;
using FacebookWrapper.ObjectModel;
using Message = FacebookWrapper.ObjectModel.Message;

namespace BasicFacebookFeatures
{
    public class AgeSorter : ISorterStrategy
    {
        private FacebookObjectCollection<User> UserFriends { get; }

        private Dictionary<User, DateTime> UserFriendsCollection { get; }

        private readonly eSortAgeBy sortingMethod;

        public AgeSorter(FacebookObjectCollection<User> i_UserFriends, eSortAgeBy i_AgeSort)
        {
            UserFriends = i_UserFriends;
            UserFriendsCollection = new Dictionary<User, DateTime>(UserFriends.Count);
            sortingMethod = i_AgeSort;
            setDictionary();
        }

        private void setDictionary()
        {
            foreach (var friend in UserFriends)
            {
                DateTime newDateTime = DateTime.Parse(friend.Birthday,
                    new CultureInfo("en-US", true),
                    DateTimeStyles.AssumeLocal);
                UserFriendsCollection.Add(friend, newDateTime);
            }
        }

        public FacebookObjectCollection<User> SortCollection()
        {
            FacebookObjectCollection<User> upToDateFriendList = new FacebookObjectCollection<User>(UserFriends.Count);
            if (sortingMethod == eSortAgeBy.Ascending)
            {
                foreach (KeyValuePair<User, DateTime> friend in UserFriendsCollection.OrderBy(key => key.Value))
                {
                    upToDateFriendList.Add(friend.Key);
                }
            }
            else if (sortingMethod == eSortAgeBy.Descending)
            {
                foreach (KeyValuePair<User, DateTime> friend in UserFriendsCollection.OrderByDescending(key => key.Value))
                {
                    upToDateFriendList.Add(friend.Key);
                }
            }
            
            return upToDateFriendList;
        }
    }

    public enum eSortAgeBy
    {
        Ascending = 1,
        Descending
    }
}
