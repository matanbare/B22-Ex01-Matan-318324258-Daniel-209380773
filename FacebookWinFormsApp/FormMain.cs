using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public User UserResults{ get; set; }
        public LoginResult Login{ get; set; }
        public FacebookObjectCollection<Post> UserPosts { get; set; }


        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("gtaabc92"); /// the current password for Desig Patter

            Login = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                "484536506563845",
                /// requested permissions:
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info"
            /// add any relevant permissions
            );


            if (!string.IsNullOrEmpty(Login.AccessToken))
            {
                UserResults = Login.LoggedInUser;
                UserPosts = UserResults.Posts;

                buttonLogin.Text = $"Logged in as {Login.LoggedInUser.Name}";
                Album album = new Album();
                
                pictureBoxProfileImage.LoadAsync(UserResults.PictureLargeURL);
                //pictureBoxCoverPhoto.LoadAsync(UserResults.Albums);

            }
            // add cover photo
            foreach (var album in UserResults.Albums)
            {
                if (album.Name.Equals("Cover photos"))
                {
                    pictureBoxCoverPhoto.LoadAsync(album.PictureAlbumURL);
                }
            }
            // add number of friends
            if (labelFriendsNumber != null)
            {
                labelFriendsNumber.Text = string.Format("Friends: {0}", UserResults.Friends.Count);
            }

            foreach (var friend in UserResults.Friends)
            {
                listBoxFrinends.Items.Add(friend.Name);
                
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }

        private void buttonFetchPhotosLikes_Click(object sender, EventArgs e)
        {
            int mostLikedPhoto = int.MinValue;
            int mostCommentsPhoto = int.MinValue;
            string mostCommentsPhotoUrl = null;
            string mostLikedPhotoUrl = null;

            int totalCommentsPhoto = 0;
            int totalLikesPhoto = 0;


            foreach (var album in UserResults.Albums)
            {
                foreach (var photo in album.Photos)
                {
                    totalCommentsPhoto += photo.Comments.Count;
                    totalLikesPhoto += photo.LikedBy.Count;

                    if (mostLikedPhoto < photo.LikedBy.Count)
                    {
                        mostLikedPhoto = photo.LikedBy.Count;
                        mostLikedPhotoUrl = photo.PictureAlbumURL;
                    }

                    if (mostCommentsPhoto < photo.Comments.Count)
                    {
                        mostCommentsPhoto = photo.Comments.Count;
                        mostCommentsPhotoUrl = photo.PictureAlbumURL;
                    }
                }
                
            }

            labelTotalLikes.Text = string.Format("Total Likes: {0}", totalLikesPhoto);
            labelTotalComments.Text = string.Format("Total Comments: {0}", totalCommentsPhoto);

            pictureBoxMostComments.LoadAsync(mostCommentsPhotoUrl);
            pictureBoxMostComments.Enabled = true;

            pictureBoxMostLiked.LoadAsync(mostLikedPhotoUrl);
            pictureBoxMostLiked.Enabled = true;
        }
    }
}
