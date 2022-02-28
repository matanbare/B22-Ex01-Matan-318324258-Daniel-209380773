using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class UserProfile
    {
        private const string k_CoverAlbumName = "Cover photos";

        public string ProfileImageUrl { get; set; }
        public string CoverImageUrl { get; set; }
        public UserBio Bio { get; set; }
        public int FriendsCount { get; set; }
        public FacebookObjectCollection<User> FriendsList { get; set; }


        public UserProfile(User i_LoggedInUser)
        {
            ProfileImageUrl = i_LoggedInUser.PictureLargeURL;
            FriendsCount = i_LoggedInUser.Friends.Count;
            FriendsList = i_LoggedInUser.Friends;
            setCoverUrl(i_LoggedInUser.Albums);
            Bio = new UserBio(i_LoggedInUser.Location.Name,
                i_LoggedInUser.Birthday,
                i_LoggedInUser.Gender.ToString());
        }

        private void setCoverUrl(FacebookObjectCollection<Album> i_UserAlbums)
        {
            foreach (var album in i_UserAlbums)
            {
                if (album.Name.Equals(k_CoverAlbumName))
                {
                   CoverImageUrl = album.PictureAlbumURL;
                }
            }
        }

        public string[] GetUserFriendsName()
        {
            int friendsCounter = 0;
            string[] friendsNameList = new string[FriendsList.Count];

            foreach (var friend in FriendsList)
            {
                friendsNameList[friendsCounter] = friend.Name;
                friendsCounter++;
            }

            return friendsNameList;
        }

        public string GetFriendProfileImageUrl(string i_FriendName)
        {
            string friendProfileImageUrl = null;

            foreach (var friend in FriendsList)
            {
                if (friend.Name.Equals(i_FriendName))
                {
                    friendProfileImageUrl = friend.PictureLargeURL;
                }
            }

            return friendProfileImageUrl;
        }
    }
}
