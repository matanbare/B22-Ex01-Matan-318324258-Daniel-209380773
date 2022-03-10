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
            this.button2 = new System.Windows.Forms.Button();
            this.buttonStartTimerPost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFriendProfileImg = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            this.panelBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(845, 238);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 57;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(303, 134);
            this.pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            this.pictureBoxProfileImage.Size = new System.Drawing.Size(231, 172);
            this.pictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfileImage.TabIndex = 58;
            this.pictureBoxProfileImage.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 67);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 59;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 28);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 60;
            this.buttonLogin.Text = "LoginResult";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.White;
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(610, 373);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(220, 222);
            this.listBoxFriends.TabIndex = 63;
            this.listBoxFriends.Click += new System.EventHandler(this.listBoxFriends_Click);
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Transparent;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.ForeColor = System.Drawing.Color.Black;
            this.labelFriends.Location = new System.Drawing.Point(650, 334);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(74, 20);
            this.labelFriends.TabIndex = 65;
            this.labelFriends.Text = "Friends:";
            // 
            // labelBio
            // 
            this.labelBio.AutoSize = true;
            this.labelBio.BackColor = System.Drawing.Color.Transparent;
            this.labelBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBio.Location = new System.Drawing.Point(386, 331);
            this.labelBio.Name = "labelBio";
            this.labelBio.Size = new System.Drawing.Size(46, 24);
            this.labelBio.TabIndex = 66;
            this.labelBio.Text = "Bio:";
            // 
            // panelBio
            // 
            this.panelBio.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.panelBio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBio.Controls.Add(this.labelBirthday);
            this.panelBio.Controls.Add(this.labelGender);
            this.panelBio.Controls.Add(this.labelFrom);
            this.panelBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelBio.Location = new System.Drawing.Point(303, 373);
            this.panelBio.Name = "panelBio";
            this.panelBio.Size = new System.Drawing.Size(231, 132);
            this.panelBio.TabIndex = 67;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(3, 91);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(71, 20);
            this.labelBirthday.TabIndex = 2;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(3, 51);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 20);
            this.labelGender.TabIndex = 1;
            this.labelGender.Text = "Gender:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(3, 14);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(50, 20);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // buttonPhotosTracker
            // 
            this.buttonPhotosTracker.BackColor = System.Drawing.Color.White;
            this.buttonPhotosTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPhotosTracker.Location = new System.Drawing.Point(57, 379);
            this.buttonPhotosTracker.Name = "buttonPhotosTracker";
            this.buttonPhotosTracker.Size = new System.Drawing.Size(158, 43);
            this.buttonPhotosTracker.TabIndex = 68;
            this.buttonPhotosTracker.Text = "Photos Tracker";
            this.buttonPhotosTracker.UseVisualStyleBackColor = false;
            this.buttonPhotosTracker.Click += new System.EventHandler(this.buttonPhotosTracker_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 43);
            this.button2.TabIndex = 69;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonStartTimerPost
            // 
            this.buttonStartTimerPost.Location = new System.Drawing.Point(57, 456);
            this.buttonStartTimerPost.Name = "buttonStartTimerPost";
            this.buttonStartTimerPost.Size = new System.Drawing.Size(158, 43);
            this.buttonStartTimerPost.TabIndex = 70;
            this.buttonStartTimerPost.Text = "Timer Post";
            this.buttonStartTimerPost.UseVisualStyleBackColor = true;
            this.buttonStartTimerPost.Click += new System.EventHandler(this.buttonStartTimerPost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Magic Fetures:";
            // 
            // pictureBoxFriendProfileImg
            // 
            this.pictureBoxFriendProfileImg.Location = new System.Drawing.Point(737, 510);
            this.pictureBoxFriendProfileImg.Name = "pictureBoxFriendProfileImg";
            this.pictureBoxFriendProfileImg.Size = new System.Drawing.Size(93, 85);
            this.pictureBoxFriendProfileImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfileImg.TabIndex = 72;
            this.pictureBoxFriendProfileImg.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(249, 622);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(339, 23);
            this.progressBar.TabIndex = 73;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 250;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.Location = new System.Drawing.Point(245, 582);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(0, 20);
            this.labelProgressBar.TabIndex = 74;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(18, 102);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(133, 24);
            this.checkBoxAutoLogin.TabIndex = 75;
            this.checkBoxAutoLogin.Text = "Remember Me";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.facebookBackgroundApp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 657);
            this.Controls.Add(this.checkBoxAutoLogin);
            this.Controls.Add(this.labelProgressBar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBoxFriendProfileImg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartTimerPost);
            this.Controls.Add(this.button2);
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
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonStartTimerPost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfileImg;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
    }
}

