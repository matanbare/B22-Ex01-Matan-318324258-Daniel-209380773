using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.ENums;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserPhotosDetails
    {
        private readonly Dictionary<User, BestFriendsTracker> r_FriendsCommentsAndLikesDictionary;

        public FacebookObjectCollection<Album> AlbumsList { get; set; }

        public FacebookObjectCollection<User> FriendsList { get; set; }

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
            r_FriendsCommentsAndLikesDictionary = new Dictionary<User, BestFriendsTracker>(FriendsList.Count);
            takeAllDetails();
        }

        private void takeAllDetails()
        {
            CalculatePhotoDetails();
            SetFriendsListNames();
        }

        public void CalculatePhotoDetails()
        {
            foreach (var album in AlbumsList)
            {
                foreach (var photo in album.Photos)
                {
                    TotalCommentsPhoto += photo.Comments.Count;
                    TotalLikesPhoto += photo.LikedBy.Count;

                    setPhotosDetails(photo, eTotalCount.Comments);
                    setPhotosDetails(photo, eTotalCount.Likes);

                    foreach (var user in photo.LikedBy)
                    {
                        foundLikesAndCommentsForUsers(user, eTotalCount.Likes);
                    }

                    foreach (var comment in photo.Comments)
                    {
                        foundLikesAndCommentsForUsers(comment.From, eTotalCount.Comments);
                    }
                }
            }
        }

        private void setPhotosDetails(Photo i_Photo, eTotalCount i_TotalCountType)
        {
            switch (i_TotalCountType)
            {
                case eTotalCount.Comments:
                    if (MostCommentsPhoto < i_Photo.Comments.Count)
                    {
                        MostCommentsPhoto = i_Photo.Comments.Count;
                        MostCommentsPhotoUrl = i_Photo.PictureAlbumURL;
                    }

                    break;
                case eTotalCount.Likes:
                    if (MostLikedPhoto < i_Photo.LikedBy.Count)
                    {
                        MostLikedPhoto = i_Photo.Comments.Count;
                        MostLikedPhotoUrl = i_Photo.PictureAlbumURL;
                    }

                    break;
            }
        }

        private void foundLikesAndCommentsForUsers(User i_UserFriend, eTotalCount i_Total)
        {
            if (r_FriendsCommentsAndLikesDictionary.ContainsKey(i_UserFriend))
            {
                updateTotalCountCountFacebookReaction(i_Total, i_UserFriend);
            }
        }

        public void SetFriendsListNames()
        {
            foreach (var user in FriendsList)
            {
                r_FriendsCommentsAndLikesDictionary.Add(user, new BestFriendsTracker(user.Name));
            }
        }

        public string BestFriendsLikes(out int i_NumberOfLikes, out string i_ImageUrl)
        {
            return calculateTotalCountSum(eTotalCount.Likes, out i_NumberOfLikes, out i_ImageUrl);
        }

        public string BestFriendComments(out int i_NumberOfComments, out string i_ImageUrl)
        {
            return calculateTotalCountSum(eTotalCount.Comments, out i_NumberOfComments, out i_ImageUrl);
        }

        private string calculateTotalCountSum(eTotalCount i_TotalCount, out int i_NumberOfComments, out string i_ImageUrl)
        {
            string friendName = null;
            int maximumCount = 0;

            i_ImageUrl = null;

            foreach (var friendsTracker in r_FriendsCommentsAndLikesDictionary)
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

        private int getTotalCountFacebookReaction(eTotalCount i_TotalCount, User i_UserFriend)
        {
            int totalCount = 0;

            switch (i_TotalCount)
            {
                case eTotalCount.Likes:
                    totalCount = r_FriendsCommentsAndLikesDictionary[i_UserFriend].TotalLikes;
                    break;
                case eTotalCount.Comments:
                    totalCount = r_FriendsCommentsAndLikesDictionary[i_UserFriend].TotalComments;
                    break;
            }

            return totalCount;
        }

        private void updateTotalCountCountFacebookReaction(eTotalCount i_TotalCount, User i_UserFriend)
        {
            switch (i_TotalCount)
            {
                case eTotalCount.Likes:
                    r_FriendsCommentsAndLikesDictionary[i_UserFriend].TotalLikes++;
                    break;
                case eTotalCount.Comments:
                    r_FriendsCommentsAndLikesDictionary[i_UserFriend].TotalComments++;
                    break;
            }
        }
    }
}
