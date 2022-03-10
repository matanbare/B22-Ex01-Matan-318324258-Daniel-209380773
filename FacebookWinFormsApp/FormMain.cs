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
        private const int k_StepOneInProgressBar = 25;
        private const int k_StepTwoInProgressBar = 50;
        private const int k_StepThreeInProgressBar = 75;
        private User LoggedInUser{ get; set; }
        private LoginResult LoginResult{ get; set; }
        private UserProfile Profile { get; set; }

        private FormPhotosTracker m_FormPhotosTracker;



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
                setProfileData();
            }
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

        private void buttonPhotosTracker_Click(object sender, EventArgs e)
        {
            timerProgressBar.Start();

            m_FormPhotosTracker = new FormPhotosTracker(LoggedInUser);
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarSteps();
        }

        private void progressBarSteps()
        {
            progressBar.Increment(k_StepsInProgressBar);
            labelProgressBar.BackColor = progressBar.BackColor;

            if (progressBar.Value > k_StepsInProgressBar && progressBar.Value <= k_StepOneInProgressBar)
            {
                labelProgressBar.Text = $"In progress...";
            }
            else if(progressBar.Value > k_StepOneInProgressBar && progressBar.Value <= k_StepTwoInProgressBar)
            {
                labelProgressBar.Text = $"Load images, likes and comments...";
            }
            else if (progressBar.Value > k_StepTwoInProgressBar && progressBar.Value <= k_StepThreeInProgressBar)
            {
                labelProgressBar.Text = $"We passed the half, be patient.";
            }
            else if (progressBar.Value > k_StepThreeInProgressBar && progressBar.Value < progressBar.Maximum)
            {
                labelProgressBar.Text = $"Almost there...";
            }
            else if (progressBar.Value == progressBar.Maximum)
            {
                labelProgressBar.Text = $"Done!";
                m_FormPhotosTracker.Show();
            }
        }
    }
}
