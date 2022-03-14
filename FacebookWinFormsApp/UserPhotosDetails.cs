using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserPhotosDetails
    {
        public FacebookObjectCollection<Album> AlbumsList { get; set; }
        public FacebookObjectCollection<User> FriendsList { get; set; }
        private readonly Dictionary<User, BestFriendsTracker> FriendsCommentsAndLikesDictionary;
        public int MostLikedPhoto { get; set; } = int.MinValue;
        public int MostCommentsPhoto { get; set; } = int.MinValue;
        public string MostCommentsPhotoUrl { get; set; }
        public string MostLikedPhotoUrl { get; set; }
        public int TotalCommentsPhoto { get; set; }
        public int TotalLikesPhoto { get; set; }

        public UserPhotosDetails(FacebookObjectCollection<Album> i_UserAlbums, FacebookObjectCollection<User> i_UserFriends)
        {
            AlbumsList = i_UserAlbums;
            FriendsList = i_UserFriends;
            FriendsCommentsAndLikesDictionary = new Dictionary<User, BestFriendsTracker>(FriendsList.Count);
            takeAllDetails();
        }

        private void takeAllDetails()
        {
            MostLikesAndCommentsCalculator();
            SetFriendsListNames();
            //FoundLikesAndCommentsForUsers();
        }

        public void MostLikesAndCommentsCalculator()
        {

            foreach (var album in AlbumsList)
            {
                foreach (var photo in album.Photos)
                {
                    TotalCommentsPhoto += photo.Comments.Count;
                    TotalLikesPhoto += photo.LikedBy.Count;

                    if (MostLikedPhoto < photo.LikedBy.Count)
                    {
                        MostLikedPhoto = photo.LikedBy.Count;
                        MostLikedPhotoUrl = photo.PictureAlbumURL;
                    }

                    if (MostCommentsPhoto < photo.Comments.Count)
                    {
                        MostCommentsPhoto = photo.Comments.Count;
                        MostCommentsPhotoUrl = photo.PictureAlbumURL;
                    }

                    foreach (var user in photo.LikedBy)
                    {
                        FoundLikesAndCommentsForUsers(user, eTotal.Likes);
                    }

                    foreach (var comment in photo.Comments)
                    {
                        FoundLikesAndCommentsForUsers(comment.From, eTotal.Comments);

                    }
                }
            }
        }

        public void FoundLikesAndCommentsForUsers(User i_UserFriend, eTotal i_Total)
        {
            if (FriendsCommentsAndLikesDictionary.ContainsKey(i_UserFriend))
            {
                updateTotalCountFacebookReaction(i_Total, i_UserFriend);
            }
        }

        public void SetFriendsListNames()
        {
            int index = 0;

            foreach (var user in FriendsList)
            {
                FriendsCommentsAndLikesDictionary.Add(user, new BestFriendsTracker(user.Name));
            }
        }

        public string BestFriendsLikes(out int i_NumberOfLikes, out string i_ImageUrl)
        {
            return CalculateTotalSum(eTotal.Likes, out i_NumberOfLikes, out i_ImageUrl);
        }

        public string BestFriendComments(out int i_NumberOfComments ,out string i_ImageUrl)
        {
            return CalculateTotalSum(eTotal.Comments, out i_NumberOfComments, out i_ImageUrl);
        }

        private string CalculateTotalSum(eTotal i_TotalCount, out int i_NumberOfComments, out string i_ImageUrl)
        {
            string friendName = null;
            int maximumCount = 0;

            i_ImageUrl = null;

            foreach (var friendsTracker in FriendsCommentsAndLikesDictionary)
            {
                if (getTotalCountFacebookReaction(i_TotalCount, friendsTracker.Key) >= maximumCount)
                {
                    friendName = friendsTracker.Value.Name;
                    i_NumberOfComments = maximumCount;
                    i_ImageUrl = friendsTracker.Key.PictureLargeURL;

                }
            }

            i_NumberOfComments = maximumCount;

            return friendName;
        }

        private int getTotalCountFacebookReaction(eTotal i_TotalCount, User i_UserFriend)
        {
            int totalCount = 0;

            switch (i_TotalCount)
            {
                case eTotal.Likes:
                    totalCount = FriendsCommentsAndLikesDictionary[i_UserFriend].TotalLikes;
                    break;
                case eTotal.Comments:
                    totalCount = FriendsCommentsAndLikesDictionary[i_UserFriend].TotalComments;
                    break;
            }

            return totalCount;
        }

        private void updateTotalCountFacebookReaction(eTotal i_TotalCount, User i_UserFriend)
        {
            switch (i_TotalCount)
            {
                case eTotal.Likes:
                    FriendsCommentsAndLikesDictionary[i_UserFriend].TotalLikes++;
                    break;
                case eTotal.Comments:
                    FriendsCommentsAndLikesDictionary[i_UserFriend].TotalComments++;
                    break;
            }
        }
    }

    public enum eTotal
    {
        Likes = 0,
        Comments
    }
}
