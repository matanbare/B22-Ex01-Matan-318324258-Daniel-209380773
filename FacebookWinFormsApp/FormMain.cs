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


            int nuberOfLikes = 0;
            foreach (var post in UserPosts)
            {
                listBoxFrinends.Items.Add("Name:" + post.Name);
                listBoxFrinends.Items.Add("Description:" + post.Description);
                listBoxFrinends.Items.Add("Message:" + post.Message);
                listBoxFrinends.Items.Add("Caption:" + post.Caption);
                if (post.Like())
                {
                    for (int i = 0; i < post.LikedBy.Count; i++)
                    {
                        listBoxFrinends.Items.Add("    " + i + 1 + ".Liked by:" + post.LikedBy[i].Name);
                        nuberOfLikes++;
                    }
                }
                else
                {
                    listBoxFrinends.Items.Add("    " + "NO LIKES!!!");
                }

            }
            listBoxFrinends.Items.Add("Number Of Likes:" + nuberOfLikes);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
        }
    }
}
