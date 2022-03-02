using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Timer = System.Timers.Timer;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User LoggedInUser{ get; set; }
        private LoginResult LoginResult{ get; set; }
        private UserProfile Profile { get; set; }


        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("gtaabc92"); /// the current password for Desig Patter

            LoginResult = FacebookService.Login(
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
                "groups_access_member_info",
                "publish_to_groups"
                /// add any relevant permissions
            );


            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;

                buttonLogin.Text = $"Logged in as {LoginResult.LoggedInUser.Name}";

               Profile = new UserProfile(LoggedInUser);
               setProfileData();
               buttonLogin.Enabled = false;
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "LoginResult";
        }

        private void setProfileData()
        {
            pictureBoxProfileImage.LoadAsync(Profile.ProfileImageUrl);
            pictureBoxCoverPhoto.LoadAsync(Profile.CoverImageUrl);
            labelBirthday.Text += Profile.Bio.Birthday;
            labelGender.Text += Profile.Bio.Gender;
            labelFrom.Text += Profile.Bio.From;
            labelFriends.Text = $"Friends:{Profile.FriendsCount}";

            foreach (var item in Profile.GetUserFriendsName())
            {
                listBoxFriends.Items.Add(item);
            }
        }

        private void listBoxFriends_Click(object sender, EventArgs e)
        {
            foreach (var friend in LoggedInUser.Friends)
            {
                if (friend.Name.Equals(listBoxFriends.SelectedItem))
                {
                    pictureBoxFriendProfileImg.LoadAsync(Profile.GetFriendProfileImageUrl((string)(listBoxFriends.SelectedItem)));
                }
            }
        }

        private void buttonStartTimerPost_Click(object sender, EventArgs e)
        {
            FormSchedulePosts formSchedulePosts = new FormSchedulePosts(LoggedInUser);

            formSchedulePosts.Show();
        }
    }
}
