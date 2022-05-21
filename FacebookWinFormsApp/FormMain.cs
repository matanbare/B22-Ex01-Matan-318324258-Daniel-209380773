using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form, IProgressBarListener
    {
        private const int k_StepsInProgressBar = 1;
        private const int k_startPoint = 0;
        private const string k_CoverAlbumName = "Cover photos";
        private const string k_ProgressBarMessageFirst = "In progress...";
        private const string k_ProgressBarMessageLast = "Done!";
        private const string k_DisplayMemberPropertyName = "Name";
        private const string k_EmptyPictureUrl = "https://cdn.discordapp.com/attachments/643135463275888650/953215889656926278/1483382.jpg";

        private ISorterStrategy FriendsSortSorterStrategy { get; set; }

        private IScreen Screen { get; set; }

        private FacadeLogicManager FacadeLogicManager { get; set; }

        private User FacebookLoggedInUser { get; set; }

        private ILoginable LoginAdapter { get; } = new FacebookAdapter();

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 20;
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
            comboBoxFriendsSortBy.SelectedIndex = k_startPoint;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (ApplicationSettings.Instance.AutoLogin)
            {
               new Thread(autoLogin).Start();
            }
        }

        private void autoLogin()
        {
            LoginAdapter.AutoLogin();
            FacebookLoggedInUser = (LoginAdapter as FacebookAdapter).LoggedInUser;

            buttonLogin.Invoke(new Action(buttonLoginStatusAfterAutoLogin));
            setProfileData();
        }

        private void buttonLoginStatusAfterAutoLogin()
        {
            buttonLogin.Text = $"Logged in as {FacebookLoggedInUser.Name}";
            buttonLogin.Enabled = false;
            enableFeaturesButtons(true);
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
            try
            {
                LoginAdapter.Login();
                FacebookLoggedInUser = (LoginAdapter as FacebookAdapter).LoggedInUser;
                buttonLogin.Text = $"Logged in as {FacebookLoggedInUser.Name}";
                new Thread(setProfileData).Start();
                
                listBoxLikedPages.DataSource = pageBindingSource;
                listBoxLikedPages.DisplayMember = k_DisplayMemberPropertyName;

                listBoxFriends.DataSource = userBindingSource;
                listBoxFriends.DisplayMember = k_DisplayMemberPropertyName;

                buttonLogin.Enabled = false;
                enableFeaturesButtons(true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Login Failed");
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
                pictureBoxLikedPage,
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

            linkLabelFriendProfile.Text = string.Empty;
            linkLabelLikedPage.Text = string.Empty;
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
                listBox.DataSource = null;
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
            startFeatureAfterClicked(eScreenType.SchedulePost);
        }

        private void buttonPhotosDetails_Click(object sender, EventArgs e)
        {
            IProgressBarListener listener = this;
            FacadeLogicManager.UserPhotosDetails.AddListener(listener);
            startFeatureAfterClicked(eScreenType.PhotoDetails);
        }

        private void startFeatureAfterClicked(eScreenType iScreenTypeType)
        {
            Screen = ScreenFactory.CreateScreen(iScreenTypeType, FacadeLogicManager);
            Screen.LoadFeature();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBarStartLoading(labelPhotosDetails, timerProgressBarPhotoTracker, progressBarPhotoDetails);
        }

        private void timerProgressBarPost_Tick(object sender, EventArgs e)
        {
            progressBarStartLoading(labelTimerPost, timerProgressBarPost, progressBarTimerPost);
        }

        private void progressBarStartLoading(Label i_Label, System.Windows.Forms.Timer i_Timer, ProgressBar i_ProgressBar)
        {
            i_ProgressBar.Increment(k_StepsInProgressBar);
            i_Label.Text = $"{i_ProgressBar.Value}%";

            if (i_ProgressBar.Value == i_ProgressBar.Maximum)
            {
                i_Label.Text = k_ProgressBarMessageLast;
                i_Timer.Enabled = false;
                (Screen as Form).Show();
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

            foreach (Album album in FacebookLoggedInUser.Albums)
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
            FacadeLogicManager = new FacadeLogicManager(FacebookLoggedInUser);
            checkBoxAutoLogin.Invoke(new Action(() => checkBoxAutoLogin.Enabled = true));
            pictureBoxProfileImage.LoadAsync(FacebookLoggedInUser.PictureLargeURL);
            pictureBoxCoverPhoto.LoadAsync(getCoverPhoto());

            if (FacebookLoggedInUser.Location != null)
            {
                setBioLabelsDetails(FacebookLoggedInUser.Birthday, FacebookLoggedInUser.Gender.ToString(), FacebookLoggedInUser.Friends.Count, FacebookLoggedInUser.Location.Name);
            }
            else
            {
                setBioLabelsDetails(FacebookLoggedInUser.Birthday, FacebookLoggedInUser.Gender.ToString(), FacebookLoggedInUser.Friends.Count);
            }

            Invoke(new Action(() => pageBindingSource.DataSource = FacebookLoggedInUser.LikedPages));
            Invoke(new Action(() => userBindingSource.DataSource = FacebookLoggedInUser.Friends));
        }

        private void setBioLabelsDetails(string i_Birthday = "", string i_Gender = "", int i_FriendsCount = 0, string i_From = "")
        {
            labelBirthday.Invoke(new Action(() => labelBirthday.Text = $"Birthday:{i_Birthday}"));
            labelGender.Invoke(new Action(() => labelGender.Text = $"Gender:{i_Gender}"));
            labelFrom.Invoke(new Action(() => labelFrom.Text = $"From:{i_From}"));
            labelFriends.Invoke(new Action(() => labelFriends.Text = i_FriendsCount > 0 ? $"Friends:{i_FriendsCount}" : $"Friends:"));
        }

        private void likedPagesURl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as LinkLabel).Text;

            Process.Start(url);
        }

        private void friendUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (sender as LinkLabel).Text;

            Process.Start(url);
        }

        public void UpdateProgressBar(string i_AlbumName, int i_NumberOfAlbums)
        {
            progressBarPhotoDetails.Maximum = FacebookLoggedInUser.Albums.Count;
            progressBarPhotoDetails.Increment(1);
            Thread.Sleep(200);
            if (progressBarPhotoDetails.Value == progressBarPhotoDetails.Maximum)
            {
                labelPhotosDetails.Text = k_ProgressBarMessageLast;
                
                (Screen as Form).Show();
            }
            else
            {
                string text =
                    $"Load Album {i_AlbumName} {i_NumberOfAlbums} / {FacebookLoggedInUser.Albums.Count}";

                changeLabelText(labelPhotosDetails, text);
            }

            Application.DoEvents();
        }

        private void changeLabelText(Label i_Label, string i_TextToChange)
        {
            i_Label.Text = i_TextToChange;
        }

        private void comboBoxFriendsSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Type = string.Concat(comboBoxFriendsSortBy.SelectedItem.ToString().Where(ch => !char.IsWhiteSpace(ch)));

            if (EFriendsSortType.eFriendsSortType.TryParse(Type, out EFriendsSortType.eFriendsSortType friendsSortType))
            {
                   FriendsSortSorterStrategy = setStrategy(friendsSortType);
                   listBoxFriends.DataSource = null;

                   listBoxFriends.Items.Clear();
                   listBoxFriends.SelectedIndexChanged += ListBoxFriends_SelectedIndexChanged;

                   FacebookObjectCollection<User> sortedFriendsList = FriendsSortSorterStrategy.SortCollection();

                   foreach (var friend in sortedFriendsList)
                   {
                       listBoxFriends.Items.Add(friend);
                   }

                   labelFriends.Text = $"Friends: {sortedFriendsList.Count}";
            }
            else
            {
                listBoxFriends.SelectedIndexChanged -= ListBoxFriends_SelectedIndexChanged;
                listBoxFriends.DataSource = userBindingSource;
                listBoxFriends.DisplayMember = k_DisplayMemberPropertyName;
            }
        }

        private void ListBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = listBoxFriends.SelectedItem as User;
            
            if (selectedUser != null)
            {
                pictureBoxFriendProfile.LoadAsync(selectedUser.PictureNormalURL);
                linkLabelFriendProfile.Text = selectedUser.Link;
            }
        }

        private ISorterStrategy setStrategy(EFriendsSortType.eFriendsSortType i_SortType)
        {
            ISorterStrategy concreteSorterStrategy = null;

            switch (i_SortType)
            {
                case EFriendsSortType.eFriendsSortType.AgeASC:
                    concreteSorterStrategy = new AgeSorter(FacebookLoggedInUser.Friends, eSortAgeBy.Ascending);
                    break;
                case EFriendsSortType.eFriendsSortType.AgeDEC:
                    concreteSorterStrategy = new AgeSorter(FacebookLoggedInUser.Friends, eSortAgeBy.Descending);
                    break;
                case EFriendsSortType.eFriendsSortType.Female:
                    concreteSorterStrategy = new GenderSorter(FacebookLoggedInUser.Friends, User.eGender.female);
                    break;
                case EFriendsSortType.eFriendsSortType.Male:
                    concreteSorterStrategy = new GenderSorter(FacebookLoggedInUser.Friends, User.eGender.male);
                    break;
            }

            return concreteSorterStrategy;
        }
    }
}
