using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserPhotosTracker
    {
        public FacebookObjectCollection<Album> AlbumsList { get; set; }
        public FacebookObjectCollection<User> FriendsList { get; set; }
        private readonly Dictionary<User, BestFriendsTracker> FriendsCommentsAndLikesDictionary;
        public int MostLikedPhoto { get; set; } = int.MinValue;
        public int MostCommentsPhoto { get; set; } = int.MinValue;
        public string MostCommentsPhotoUrl { get; set; } = null;
        public string MostLikedPhotoUrl { get; set; } = null;
        public int TotalCommentsPhoto { get; set; } = 0;
        public int TotalLikesPhoto { get; set; } = 0;

        public UserPhotosTracker(FacebookObjectCollection<Album> i_UserAlbums, FacebookObjectCollection<User> i_UserFriends)
        {
            AlbumsList = i_UserAlbums;
            FriendsList = i_UserFriends;
            FriendsCommentsAndLikesDictionary = new Dictionary<User, BestFriendsTracker>(FriendsList.Count);
            takeAllDetails();
        }

        public void takeAllDetails()
        {
            MostLikesAndCommentsCalculator();
            SetFriendsListNames();
            FoundLikesAndCommentsForUsers();
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
                }
            }
        }

        public void FoundLikesAndCommentsForUsers()
        {
            foreach (var album in AlbumsList)
            {
                foreach (var photo in album.Photos)
                {
                    FacebookObjectCollection<User> photoLikedByList = photo.LikedBy;
                    FacebookObjectCollection<Comment> photoCommentsByList = photo.Comments;

                    foreach (var user in photoLikedByList)
                    {
                        if (FriendsCommentsAndLikesDictionary.ContainsKey(user))
                        {
                            FriendsCommentsAndLikesDictionary[user].TotalLikes++;
                        }
                    }

                    foreach (var comment in photoCommentsByList)
                    {
                        if (FriendsCommentsAndLikesDictionary.ContainsKey(comment.From))
                        {
                            FriendsCommentsAndLikesDictionary[comment.From].TotalComments++;
                        }
                       
                    }
                }
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
            string friendName = null;
            int maximumLikes = 0;

            i_ImageUrl = null;

            foreach (var friendsTracker in FriendsCommentsAndLikesDictionary)
            {
                if (friendsTracker.Value.TotalLikes >= maximumLikes)
                {
                    friendName = friendsTracker.Value.Name;
                    i_ImageUrl = friendsTracker.Key.PictureLargeURL;
                }
            }

            i_NumberOfLikes = maximumLikes;

            return friendName;
        }

        public string BestFriendComments(out int i_NumberOfComments ,out string i_ImageUrl)
        {
            string friendName = null;
            int maximumComments = 0;
            
            
            i_ImageUrl = null;

            foreach (var friendsTracker in FriendsCommentsAndLikesDictionary)
            {
                if (friendsTracker.Value.TotalComments >= maximumComments)
                {
                    friendName = friendsTracker.Value.Name;
                    i_NumberOfComments = maximumComments;
                    i_ImageUrl = friendsTracker.Key.PictureLargeURL;
                    
                }
            }
            i_NumberOfComments = maximumComments;

            return friendName;
        }
    }
}
