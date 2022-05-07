namespace BasicFacebookFeatures
{
    public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label uRLLabel;
            System.Windows.Forms.Label linkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelBio = new System.Windows.Forms.Label();
            this.panelBio = new System.Windows.Forms.Panel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.buttonPhotosTracker = new System.Windows.Forms.Button();
            this.buttonStartTimerPost = new System.Windows.Forms.Button();
            this.labelMagicFetures = new System.Windows.Forms.Label();
            this.progressBarPhotoDetails = new System.Windows.Forms.ProgressBar();
            this.timerProgressBarPhotoTracker = new System.Windows.Forms.Timer(this.components);
            this.labelPhotosDetails = new System.Windows.Forms.Label();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.progressBarTimerPost = new System.Windows.Forms.ProgressBar();
            this.timerProgressBarPost = new System.Windows.Forms.Timer(this.components);
            this.labelTimerPost = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelLakdePages = new System.Windows.Forms.Label();
            this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
            this.linkLabelLikedPage = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.linkLabelFriendProfile = new System.Windows.Forms.LinkLabel();
            this.labelFriendsSortBy = new System.Windows.Forms.Label();
            this.comboBoxFriendsSortBy = new System.Windows.Forms.ComboBox();
            uRLLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // uRLLabel
            // 
            uRLLabel.AutoSize = true;
            uRLLabel.BackColor = System.Drawing.Color.Transparent;
            uRLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uRLLabel.ForeColor = System.Drawing.Color.White;
            uRLLabel.Location = new System.Drawing.Point(500, 867);
            uRLLabel.Name = "uRLLabel";
            uRLLabel.Size = new System.Drawing.Size(39, 15);
            uRLLabel.TabIndex = 79;
            uRLLabel.Text = "URL:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.BackColor = System.Drawing.Color.Transparent;
            linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            linkLabel.ForeColor = System.Drawing.SystemColors.Control;
            linkLabel.Location = new System.Drawing.Point(1004, 842);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(84, 15);
            linkLabel.TabIndex = 84;
            linkLabel.Text = "Profile Link:";
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(-3, 0);
            this.pictureBoxCoverPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(1409, 366);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 57;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(504, 206);
            this.pictureBoxProfileImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(384, 265);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 58;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(61, 235);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(298, 46);
            this.buttonLogout.TabIndex = 59;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(61, 165);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(298, 46);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.LightGray;
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(1008, 515);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(365, 322);
            this.listBoxFriends.TabIndex = 63;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(1003, 442);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(109, 29);
            this.labelFriends.TabIndex = 65;
            this.labelFriends.Text = "Friends:";
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.BackColor = System.Drawing.Color.Transparent;
            this.labelBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBio.ForeColor = System.Drawing.Color.White;
            this.labelBio.Location = new System.Drawing.Point(501, 466);
            this.labelBio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(59, 29);
            this.labelBio.TabIndex = 66;
            this.labelBio.Text = "Bio:";
            // 
            // panelBio
            // 
            this.panelBio.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.panelBio.BackColor = System.Drawing.Color.LightGray;
            this.panelBio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBio.Controls.Add(this.labelBirthday);
            this.panelBio.Controls.Add(this.labelGender);
            this.panelBio.Controls.Add(this.labelFrom);
            this.panelBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelBio.Location = new System.Drawing.Point(504, 515);
            this.panelBio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBio.Name = "panelBio";
            this.panelBio.Size = new System.Drawing.Size(382, 136);
            this.panelBio.TabIndex = 67;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(0, 85);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(71, 20);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(0, 52);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 20);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Gender:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(0, 17);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(50, 20);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // buttonPhotosTracker
            // 
            this.buttonPhotosTracker.BackColor = System.Drawing.Color.LightGray;
            this.buttonPhotosTracker.Enabled = false;
            this.buttonPhotosTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhotosTracker.Location = new System.Drawing.Point(96, 582);
            this.buttonPhotosTracker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPhotosTracker.Name = "buttonPhotosTracker";
            this.buttonPhotosTracker.Size = new System.Drawing.Size(263, 66);
            this.buttonPhotosTracker.TabIndex = 68;
            this.buttonPhotosTracker.Text = "Photos Tracker";
            this.buttonPhotosTracker.UseVisualStyleBackColor = false;
            this.buttonPhotosTracker.Click += new System.EventHandler(this.buttonPhotosDetails_Click);
            // 
            // buttonStartTimerPost
            // 
            this.buttonStartTimerPost.BackColor = System.Drawing.Color.LightGray;
            this.buttonStartTimerPost.Enabled = false;
            this.buttonStartTimerPost.Location = new System.Drawing.Point(96, 749);
            this.buttonStartTimerPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartTimerPost.Name = "buttonStartTimerPost";
            this.buttonStartTimerPost.Size = new System.Drawing.Size(263, 66);
            this.buttonStartTimerPost.TabIndex = 70;
            this.buttonStartTimerPost.Text = "Timer Post";
            this.buttonStartTimerPost.UseVisualStyleBackColor = false;
            this.buttonStartTimerPost.Click += new System.EventHandler(this.buttonStartTimerPost_Click);
            // 
            // labelMagicFetures
            // 
            this.labelMagicFetures.AutoSize = true;
            this.labelMagicFetures.BackColor = System.Drawing.Color.Transparent;
            this.labelMagicFetures.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagicFetures.ForeColor = System.Drawing.Color.White;
            this.labelMagicFetures.Location = new System.Drawing.Point(91, 534);
            this.labelMagicFetures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMagicFetures.Name = "labelMagicFetures";
            this.labelMagicFetures.Size = new System.Drawing.Size(186, 29);
            this.labelMagicFetures.TabIndex = 71;
            this.labelMagicFetures.Text = "Magic Fetures:";
            // 
            // progressBarPhotoDetails
            // 
            this.progressBarPhotoDetails.BackColor = System.Drawing.Color.White;
            this.progressBarPhotoDetails.Location = new System.Drawing.Point(96, 667);
            this.progressBarPhotoDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarPhotoDetails.Name = "progressBarPhotoDetails";
            this.progressBarPhotoDetails.Size = new System.Drawing.Size(260, 48);
            this.progressBarPhotoDetails.TabIndex = 73;
            // 
            // timerProgressBarPhotoTracker
            // 
            this.timerProgressBarPhotoTracker.Interval = 15;
            this.timerProgressBarPhotoTracker.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // labelPhotosDetails
            // 
            this.labelPhotosDetails.AutoSize = true;
            this.labelPhotosDetails.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelPhotosDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotosDetails.ForeColor = System.Drawing.Color.White;
            this.labelPhotosDetails.Location = new System.Drawing.Point(95, 684);
            this.labelPhotosDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhotosDetails.Name = "labelPhotosDetails";
            this.labelPhotosDetails.Size = new System.Drawing.Size(0, 16);
            this.labelPhotosDetails.TabIndex = 74;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.LightGray;
            this.checkBoxAutoLogin.Enabled = false;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(61, 304);
            this.checkBoxAutoLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(133, 24);
            this.checkBoxAutoLogin.TabIndex = 75;
            this.checkBoxAutoLogin.Text = "Remember Me";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = false;
            // 
            // progressBarTimerPost
            // 
            this.progressBarTimerPost.BackColor = System.Drawing.Color.White;
            this.progressBarTimerPost.Location = new System.Drawing.Point(96, 838);
            this.progressBarTimerPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarTimerPost.Name = "progressBarTimerPost";
            this.progressBarTimerPost.Size = new System.Drawing.Size(257, 51);
            this.progressBarTimerPost.TabIndex = 76;
            // 
            // timerProgressBarPost
            // 
            this.timerProgressBarPost.Interval = 15;
            this.timerProgressBarPost.Tick += new System.EventHandler(this.timerProgressBarPost_Tick);
            // 
            // labelTimerPost
            // 
            this.labelTimerPost.AutoSize = true;
            this.labelTimerPost.BackColor = System.Drawing.Color.SlateBlue;
            this.labelTimerPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerPost.ForeColor = System.Drawing.Color.White;
            this.labelTimerPost.Location = new System.Drawing.Point(100, 838);
            this.labelTimerPost.Name = "labelTimerPost";
            this.labelTimerPost.Size = new System.Drawing.Size(0, 24);
            this.labelTimerPost.TabIndex = 77;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.BackColor = System.Drawing.Color.LightGray;
            this.listBoxLikedPages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 20;
            this.listBoxLikedPages.Location = new System.Drawing.Point(504, 720);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(382, 142);
            this.listBoxLikedPages.TabIndex = 78;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // labelLakdePages
            // 
            this.labelLakdePages.AutoSize = true;
            this.labelLakdePages.BackColor = System.Drawing.Color.Transparent;
            this.labelLakdePages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLakdePages.ForeColor = System.Drawing.Color.White;
            this.labelLakdePages.Location = new System.Drawing.Point(501, 686);
            this.labelLakdePages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLakdePages.Name = "labelLakdePages";
            this.labelLakdePages.Size = new System.Drawing.Size(165, 29);
            this.labelLakdePages.TabIndex = 79;
            this.labelLakdePages.Text = "Liked Pages:";
            // 
            // pictureBoxLikedPage
            // 
            this.pictureBoxLikedPage.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxLikedPage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.pictureBoxLikedPage.Location = new System.Drawing.Point(780, 789);
            this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
            this.pictureBoxLikedPage.Size = new System.Drawing.Size(106, 103);
            this.pictureBoxLikedPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPage.TabIndex = 4;
            this.pictureBoxLikedPage.TabStop = false;
            // 
            // linkLabelLikedPage
            // 
            this.linkLabelLikedPage.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLikedPage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "URL", true));
            this.linkLabelLikedPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLikedPage.ForeColor = System.Drawing.Color.White;
            this.linkLabelLikedPage.Location = new System.Drawing.Point(544, 867);
            this.linkLabelLikedPage.Name = "linkLabelLikedPage";
            this.linkLabelLikedPage.Size = new System.Drawing.Size(220, 23);
            this.linkLabelLikedPage.TabIndex = 80;
            this.linkLabelLikedPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likedPagesURl_LinkClicked);
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxFriendProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(1216, 749);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(157, 143);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfile.TabIndex = 83;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // linkLabelFriendProfile
            // 
            this.linkLabelFriendProfile.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelFriendProfile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLabelFriendProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelFriendProfile.ForeColor = System.Drawing.Color.Black;
            this.linkLabelFriendProfile.Location = new System.Drawing.Point(1005, 867);
            this.linkLabelFriendProfile.Name = "linkLabelFriendProfile";
            this.linkLabelFriendProfile.Size = new System.Drawing.Size(205, 23);
            this.linkLabelFriendProfile.TabIndex = 85;
            this.linkLabelFriendProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.friendUrl_LinkClicked);
            // 
            // labelFriendsSortBy
            // 
            this.labelFriendsSortBy.AutoSize = true;
            this.labelFriendsSortBy.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendsSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsSortBy.ForeColor = System.Drawing.Color.White;
            this.labelFriendsSortBy.Location = new System.Drawing.Point(1007, 486);
            this.labelFriendsSortBy.Name = "labelFriendsSortBy";
            this.labelFriendsSortBy.Size = new System.Drawing.Size(81, 24);
            this.labelFriendsSortBy.TabIndex = 86;
            this.labelFriendsSortBy.Text = "Sort by:";
            // 
            // comboBoxFriendsSortBy
            // 
            this.comboBoxFriendsSortBy.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxFriendsSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFriendsSortBy.FormattingEnabled = true;
            this.comboBoxFriendsSortBy.Items.AddRange(new object[] {
            "Default",
            "Age ASC",
            "Age DEC",
            "Male",
            "Female"});
            this.comboBoxFriendsSortBy.Location = new System.Drawing.Point(1089, 482);
            this.comboBoxFriendsSortBy.Name = "comboBoxFriendsSortBy";
            this.comboBoxFriendsSortBy.Size = new System.Drawing.Size(121, 32);
            this.comboBoxFriendsSortBy.TabIndex = 87;
            this.comboBoxFriendsSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFriendsSortBy_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.facebookBackgroundApp1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1403, 1028);
            this.Controls.Add(this.comboBoxFriendsSortBy);
            this.Controls.Add(this.labelFriendsSortBy);
            this.Controls.Add(this.pictureBoxFriendProfile);
            this.Controls.Add(linkLabel);
            this.Controls.Add(this.linkLabelFriendProfile);
            this.Controls.Add(uRLLabel);
            this.Controls.Add(this.linkLabelLikedPage);
            this.Controls.Add(this.labelLakdePages);
            this.Controls.Add(this.pictureBoxLikedPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.labelTimerPost);
            this.Controls.Add(this.progressBarTimerPost);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.labelPhotosDetails);
            this.Controls.Add(this.progressBarPhotoDetails);
            this.Controls.Add(this.labelMagicFetures);
            this.Controls.Add(this.buttonStartTimerPost);
            this.Controls.Add(this.buttonPhotosTracker);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.panelBio);
            this.Controls.Add(this.labelBio);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfileImage);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1419, 1050);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelBio.ResumeLayout(false);
            this.panelBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Label labelBio;
        private System.Windows.Forms.Panel panelBio;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Button buttonPhotosTracker;
        private System.Windows.Forms.Button buttonStartTimerPost;
        private System.Windows.Forms.Label labelMagicFetures;
        private System.Windows.Forms.ProgressBar progressBarPhotoDetails;
        private System.Windows.Forms.Timer timerProgressBarPhotoTracker;
        private System.Windows.Forms.Label labelPhotosDetails;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
        private System.Windows.Forms.ProgressBar progressBarTimerPost;
        private System.Windows.Forms.Timer timerProgressBarPost;
        private System.Windows.Forms.Label labelTimerPost;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label labelLakdePages;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxLikedPage;
        private System.Windows.Forms.LinkLabel linkLabelLikedPage;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.LinkLabel linkLabelFriendProfile;
        private System.Windows.Forms.Label labelFriendsSortBy;
        private System.Windows.Forms.ComboBox comboBoxFriendsSortBy;
    }
}