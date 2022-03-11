namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelBio = new System.Windows.Forms.Label();
            this.panelBio = new System.Windows.Forms.Panel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.buttonPhotosTracker = new System.Windows.Forms.Button();
            this.buttonStartTimerPost = new System.Windows.Forms.Button();
            this.labelMagicFetures = new System.Windows.Forms.Label();
            this.pictureBoxFriendProfileImg = new System.Windows.Forms.PictureBox();
            this.progressBarPhotoTracker = new System.Windows.Forms.ProgressBar();
            this.timerProgressBarPhotoTracker = new System.Windows.Forms.Timer(this.components);
            this.labelPhotosTracker = new System.Windows.Forms.Label();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.progressBarTimerPost = new System.Windows.Forms.ProgressBar();
            this.timerProgressBarPost = new System.Windows.Forms.Timer(this.components);
            this.labelTimerPost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            this.panelBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfileImg)).BeginInit();
            this.SuspendLayout();
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
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(1017, 574);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(365, 322);
            this.listBoxFriends.TabIndex = 63;
            this.listBoxFriends.Click += new System.EventHandler(this.listBoxFriends_Click);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.White;
            this.labelFriends.Location = new System.Drawing.Point(1012, 534);
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
            this.labelBio.Location = new System.Drawing.Point(501, 525);
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
            this.panelBio.Location = new System.Drawing.Point(504, 574);
            this.panelBio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBio.Name = "panelBio";
            this.panelBio.Size = new System.Drawing.Size(382, 124);
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
            this.buttonPhotosTracker.Click += new System.EventHandler(this.buttonPhotosTracker_Click);
            // 
            // buttonStartTimerPost
            // 
            this.buttonStartTimerPost.BackColor = System.Drawing.Color.LightGray;
            this.buttonStartTimerPost.Enabled = false;
            this.buttonStartTimerPost.Location = new System.Drawing.Point(99, 732);
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
            // pictureBoxFriendProfileImg
            // 
            this.pictureBoxFriendProfileImg.BackColor = System.Drawing.Color.DimGray;
            this.pictureBoxFriendProfileImg.Location = new System.Drawing.Point(1203, 770);
            this.pictureBoxFriendProfileImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxFriendProfileImg.Name = "pictureBoxFriendProfileImg";
            this.pictureBoxFriendProfileImg.Size = new System.Drawing.Size(180, 161);
            this.pictureBoxFriendProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfileImg.TabIndex = 72;
            this.pictureBoxFriendProfileImg.TabStop = false;
            // 
            // progressBarPhotoTracker
            // 
            this.progressBarPhotoTracker.BackColor = System.Drawing.Color.White;
            this.progressBarPhotoTracker.Location = new System.Drawing.Point(96, 658);
            this.progressBarPhotoTracker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarPhotoTracker.Name = "progressBarPhotoTracker";
            this.progressBarPhotoTracker.Size = new System.Drawing.Size(260, 39);
            this.progressBarPhotoTracker.TabIndex = 73;
            // 
            // timerProgressBarPhotoTracker
            // 
            this.timerProgressBarPhotoTracker.Interval = 250;
            this.timerProgressBarPhotoTracker.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // labelPhotosTracker
            // 
            this.labelPhotosTracker.AutoSize = true;
            this.labelPhotosTracker.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelPhotosTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotosTracker.ForeColor = System.Drawing.Color.White;
            this.labelPhotosTracker.Location = new System.Drawing.Point(95, 684);
            this.labelPhotosTracker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhotosTracker.Name = "labelPhotosTracker";
            this.labelPhotosTracker.Size = new System.Drawing.Size(0, 24);
            this.labelPhotosTracker.TabIndex = 74;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.BackColor = System.Drawing.Color.LightGray;
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
            this.progressBarTimerPost.Location = new System.Drawing.Point(99, 808);
            this.progressBarTimerPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarTimerPost.Name = "progressBarTimerPost";
            this.progressBarTimerPost.Size = new System.Drawing.Size(263, 39);
            this.progressBarTimerPost.TabIndex = 76;
            // 
            // timerProgressBarPost
            // 
            this.timerProgressBarPost.Interval = 20;
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
            // FormMain
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.facebookBackgroundApp1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1403, 1011);
            this.Controls.Add(this.labelTimerPost);
            this.Controls.Add(this.progressBarTimerPost);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.labelPhotosTracker);
            this.Controls.Add(this.progressBarPhotoTracker);
            this.Controls.Add(this.pictureBoxFriendProfileImg);
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
            this.panelBio.ResumeLayout(false);
            this.panelBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfileImg)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxFriendProfileImg;
        private System.Windows.Forms.ProgressBar progressBarPhotoTracker;
        private System.Windows.Forms.Timer timerProgressBarPhotoTracker;
        private System.Windows.Forms.Label labelPhotosTracker;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
        private System.Windows.Forms.ProgressBar progressBarTimerPost;
        private System.Windows.Forms.Timer timerProgressBarPost;
        private System.Windows.Forms.Label labelTimerPost;
    }
}

