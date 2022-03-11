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
        private const int k_StepsInProgressBar = 1;
        private const int k_MinimumInterval = 20;
        private const string k_CoverAlbumName = "Cover photos";
        private const string k_ProgressBarMessageFirst = "In progress...";
        private const string k_ProgressBarMessageLast = "Done!";
        private User LoggedInUser{ get; set; }
        private LoginResult LoginResult{ get; set; }

        private FormPhotosTracker m_FormPhotosTracker;
        private FormSchedulePosts m_FormSchedulePosts;
        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ApplicationSettings.Instance.LastWindowState = this.WindowState;
            ApplicationSettings.Instance.LastWindowSize = this.Size;
            ApplicationSettings.Instance.LastWindowLocation = this.Location;
            ApplicationSettings.Instance.AutoLogin = this.checkBoxAutoLogin.Checked;

            ApplicationSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Size = ApplicationSettings.Instance.LastWindowSize;
            this.WindowState = ApplicationSettings.Instance.LastWindowState;
            this.Location = ApplicationSettings.Instance.LastWindowLocation;
            this.checkBoxAutoLogin.Checked = ApplicationSettings.Instance.AutoLogin;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (ApplicationSettings.Instance.AutoLogin)
            {
                autoLogin();
            }
        }

        private void autoLogin()
        {
            LoginResult result = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
            if (string.IsNullOrEmpty(result.ErrorMessage))
            {
                LoggedInUser = result.LoggedInUser;
                buttonLogin.Text = $"Logged in as {LoggedInUser.Name}";
                buttonLogin.Enabled = false;
                enableButtons();
                setProfileData();
            }
        }

        private void enableButtons()
        {
            buttonPhotosTracker.Enabled = true;
            buttonStartTimerPost.Enabled = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInitialization();
        }

        private void loginAndInitialization()
        {
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

                ApplicationSettings.Instance.AccessToken = LoginResult.AccessToken;
              
                setProfileData();
                buttonLogin.Enabled = false;
                enableButtons();
            }
            else
            {
                MessageBox.Show(LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            checkBoxAutoLogin.Checked = false;
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
        }

        private void listBoxFriends_Click(object sender, EventArgs e)
        {
            foreach (var friend in LoggedInUser.Friends)
            {
                if (friend.Name.Equals(listBoxFriends.SelectedItem))
                {
                    pictureBoxFriendProfileImg.LoadAsync(friend.PictureLargeURL);
                }
            }
        }

        private void buttonStartTimerPost_Click(object sender, EventArgs e)
        {
            setNewProgressBarLoading(labelTimerPost, timerProgressBarPost, progressBarTimerPost);
            m_FormSchedulePosts = new FormSchedulePosts(LoggedInUser);
        }

        private void buttonPhotosTracker_Click(object sender, EventArgs e)
        {
            setNewProgressBarLoading(labelPhotosTracker, timerProgressBarPhotoTracker, progressBarPhotoTracker);
            m_FormPhotosTracker = new FormPhotosTracker(LoggedInUser);
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarStartLoading(labelPhotosTracker, timerProgressBarPhotoTracker, progressBarPhotoTracker, m_FormPhotosTracker);
        }

        private void timerProgressBarPost_Tick(object sender, EventArgs e)
        {
            progressBarStartLoading(labelTimerPost, timerProgressBarPost, progressBarTimerPost, m_FormSchedulePosts);
        }

        private void progressBarStartLoading(Label i_Label, System.Windows.Forms.Timer i_Timer, ProgressBar i_ProgressBar, Form i_Form)
        {
            i_ProgressBar.Increment(k_StepsInProgressBar);
            i_Label.Text = $"{i_ProgressBar.Value}%";

            if (i_ProgressBar.Value == i_ProgressBar.Maximum)
            {
                i_Label.Text = k_ProgressBarMessageLast;
                i_Timer.Enabled = false;
                i_Timer.Interval = k_MinimumInterval;
                i_Form.Show();
            }
        }

        private void setNewProgressBarLoading(Label i_Label, System.Windows.Forms.Timer i_Timer,
            ProgressBar i_ProgressBar)
        {
            i_Label.Text = k_ProgressBarMessageFirst;
            i_ProgressBar.Value = 0;
            i_Timer.Start();
        }

        private string getCoverPhoto()
        {
            string coverImageUrl = null;

            foreach (var album in LoggedInUser.Albums)
            {
                if (album.Name.Equals(k_CoverAlbumName))
                {
                    coverImageUrl = album.PictureAlbumURL;
                }
            }

            return coverImageUrl;
        }

        private void setProfileData()
        {
            pictureBoxProfileImage.LoadAsync(LoggedInUser.PictureLargeURL);
            pictureBoxCoverPhoto.LoadAsync(getCoverPhoto());
            labelBirthday.Text += LoggedInUser.Birthday;
            labelGender.Text += LoggedInUser.Gender;
            labelFrom.Text += LoggedInUser.Location.Name;
            labelFriends.Text = $"Friends:{LoggedInUser.Friends.Count}";

            foreach (var friend in LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend.Name);
            }
        }
    }
}
