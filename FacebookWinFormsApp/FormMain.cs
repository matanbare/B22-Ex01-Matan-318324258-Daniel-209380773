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
        private const string k_DisplayMemberPropertyName = "Name";
        private const string k_EmptyPictureUrl = "https://cdn.discordapp.com/attachments/643135463275888650/953215889656926278/1483382.jpg";
        private FormPhotosDetails m_FormPhotosDetails;
        private FormSchedulePosts m_FormSchedulePosts;

        private User LoggedInUser { get; set; }

        private LoginResult LoginResult { get; set; }

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
                enableFeaturesButtons(true);
                setProfileData();
            }
        }

        private void enableFeaturesButtons(bool i_Boolean)
        {
            buttonPhotosTracker.Enabled = i_Boolean;
            buttonStartTimerPost.Enabled = i_Boolean;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInitialization();
        }

        private void loginAndInitialization()
        {
            LoginResult = FacebookService.Login(
                "484536506563845",
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
                "publish_to_groups");

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;

                buttonLogin.Text = $"Logged in as {LoginResult.LoggedInUser.Name}";

                ApplicationSettings.Instance.AccessToken = LoginResult.AccessToken;
              
                setProfileData();
                
                buttonLogin.Enabled = false;
                enableFeaturesButtons(true);
            }
            else
            {
                MessageBox.Show("Login Is Failed, Please Try Again", "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logoutFromAccount();
        }

        private void logoutFromAccount()
        {
            FacebookService.LogoutWithUI();
            initializeLoginOption();
            resetPictureBox(new PictureBox[]
            { 
                pictureBoxCoverPhoto,
                pictureBoxFriendProfile,
                pictureBoxLikedPages,
                pictureBoxProfileImage
            });
            enableFeaturesButtons(false);
            clearAllListBoxes(new ListBox[]
            {
                listBoxLikedPages,
                listBoxFriends
            });
            resetProgressBar(progressBarTimerPost, labelTimerPost);
            resetProgressBar(progressBarPhotoDetails, labelPhotosDetails);
            setBioLabelsDetails();
        }

        private void initializeLoginOption()
        {
            checkBoxAutoLogin.Checked = false;
            checkBoxAutoLogin.Enabled = false;
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
        }

        private void resetProgressBar(ProgressBar i_ProgressBar, Label i_Label)
        {
            i_ProgressBar.Value = 0;
            i_Label.Text = string.Empty;
        }

        private void clearAllListBoxes(ListBox[] i_ListBoxes)
        {
            foreach (ListBox listBox in i_ListBoxes)
            {
                listBox.Items.Clear();
            }
        }

        private void resetPictureBox(PictureBox[] i_PictureBoxes)
        {
            foreach (PictureBox pictureBox in i_PictureBoxes)
            {
                pictureBox.LoadAsync(k_EmptyPictureUrl);
            }
        }

        private void buttonStartTimerPost_Click(object sender, EventArgs e)
        {
            setNewProgressBarLoading(labelTimerPost, timerProgressBarPost, progressBarTimerPost);
            m_FormSchedulePosts = new FormSchedulePosts(LoggedInUser);
        }

        private void buttonPhotosTracker_Click(object sender, EventArgs e)
        {
            setNewProgressBarLoading(labelPhotosDetails, timerProgressBarPhotoTracker, progressBarPhotoDetails);
            m_FormPhotosDetails = new FormPhotosDetails(LoggedInUser);
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarStartLoading(labelPhotosDetails, timerProgressBarPhotoTracker, progressBarPhotoDetails, m_FormPhotosDetails);
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
                i_Form.Show();
            }
        }

        private void setNewProgressBarLoading(Label i_Label, System.Windows.Forms.Timer i_Timer, ProgressBar i_ProgressBar)
        {
            i_Label.Text = k_ProgressBarMessageFirst;
            i_ProgressBar.Value = 0;
            i_Timer.Start();
        }

        private string getCoverPhoto()
        {
            string coverImageUrl = k_EmptyPictureUrl;

            foreach (Album album in LoggedInUser.Albums)
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
            checkBoxAutoLogin.Enabled = true;
            pictureBoxProfileImage.LoadAsync(LoggedInUser.PictureLargeURL);
            pictureBoxCoverPhoto.LoadAsync(getCoverPhoto());

            if (LoggedInUser.Location != null)
            {
                setBioLabelsDetails(LoggedInUser.Birthday, LoggedInUser.Gender.ToString(), LoggedInUser.Friends.Count, LoggedInUser.Location.Name);
            }
            else
            {
                setBioLabelsDetails(LoggedInUser.Birthday, LoggedInUser.Gender.ToString(), LoggedInUser.Friends.Count);
            }

            updateListBoxItemsByCollection(listBoxLikedPages, LoggedInUser.LikedPages);
            updateListBoxItemsByCollection(listBoxFriends, LoggedInUser.Friends);
        }

        private void listBoxLikedPages_Click(object sender, EventArgs e)
        {
            updatePictureBoxImageByListBox(listBoxLikedPages, pictureBoxLikedPages, LoggedInUser.LikedPages);
        }

        private void listBoxFriends_Click(object sender, EventArgs e)
        {
            updatePictureBoxImageByListBox(listBoxFriends, pictureBoxFriendProfile, LoggedInUser.Friends);
        }

        private void updatePictureBoxImageByListBox<T>(ListBox i_ListBox, PictureBox i_PictureBox, ICollection<T> i_Collection)
        {
            foreach (T item in i_Collection)
            {
                if (item.Equals(i_ListBox.SelectedItem))
                {
                    if (item is User user)
                    {
                        i_PictureBox.LoadAsync(user.PictureLargeURL);
                        break;
                    }
                    
                    if (item is Page page)
                    {
                        i_PictureBox.LoadAsync(page.PictureLargeURL);
                        break;
                    }
                }
            }
        }

        private void updateListBoxItemsByCollection<T>(ListBox i_ListBox, ICollection<T> i_Collection)
        {
            i_ListBox.DisplayMember = k_DisplayMemberPropertyName;

            if (i_Collection != null)
            {
                foreach (T item in i_Collection)
                {
                    i_ListBox.Items.Add(item);
                }
            }
        }

        private void setBioLabelsDetails(string i_Birthday = "", string i_Gender = "", int i_FriendsCount = 0, string i_From = "")
        {
            labelBirthday.Text = $"Birthday:{i_Birthday}";
            labelGender.Text = $"Gender:{i_Gender}";
            labelFrom.Text = $"From:{i_From}";
            labelFriends.Text = i_FriendsCount > 0 ? $"Friends:{i_FriendsCount}" : $"Friends:";
        }
    }
}
