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
            this.labelFriendsNumber = new System.Windows.Forms.Label();
            this.labelFirendsList = new System.Windows.Forms.Label();
            this.listBoxFrinends = new System.Windows.Forms.ListBox();
            this.buttonFetchPhotosLikes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMostComments = new System.Windows.Forms.Label();
            this.labelMostLikedPhoto = new System.Windows.Forms.Label();
            this.pictureBoxMostLiked = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostComments = new System.Windows.Forms.PictureBox();
            this.labelPhotoDetails = new System.Windows.Forms.Label();
            this.labelTotalLikes = new System.Windows.Forms.Label();
            this.labelTotalComments = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(-5, 0);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(845, 238);
            this.pictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverPhoto.TabIndex = 57;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // pictureBoxProfileImage
            // 
            this.pictureBoxProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfileImage.Location = new System.Drawing.Point(265, 134);
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
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelFriendsNumber
            // 
            this.labelFriendsNumber.AutoSize = true;
            this.labelFriendsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsNumber.Location = new System.Drawing.Point(271, 319);
            this.labelFriendsNumber.Name = "labelFriendsNumber";
            this.labelFriendsNumber.Size = new System.Drawing.Size(0, 24);
            this.labelFriendsNumber.TabIndex = 61;
            // 
            // labelFirendsList
            // 
            this.labelFirendsList.AutoSize = true;
            this.labelFirendsList.Location = new System.Drawing.Point(28, 409);
            this.labelFirendsList.Name = "labelFirendsList";
            this.labelFirendsList.Size = new System.Drawing.Size(0, 13);
            this.labelFirendsList.TabIndex = 62;
            // 
            // listBoxFrinends
            // 
            this.listBoxFrinends.FormattingEnabled = true;
            this.listBoxFrinends.Location = new System.Drawing.Point(52, 458);
            this.listBoxFrinends.Name = "listBoxFrinends";
            this.listBoxFrinends.Size = new System.Drawing.Size(393, 56);
            this.listBoxFrinends.TabIndex = 63;
            // 
            // buttonFetchPhotosLikes
            // 
            this.buttonFetchPhotosLikes.Location = new System.Drawing.Point(591, 258);
            this.buttonFetchPhotosLikes.Name = "buttonFetchPhotosLikes";
            this.buttonFetchPhotosLikes.Size = new System.Drawing.Size(145, 23);
            this.buttonFetchPhotosLikes.TabIndex = 64;
            this.buttonFetchPhotosLikes.Text = "Fetch";
            this.buttonFetchPhotosLikes.UseVisualStyleBackColor = true;
            this.buttonFetchPhotosLikes.Click += new System.EventHandler(this.buttonFetchPhotosLikes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Friend List:";
            // 
            // labelMostComments
            // 
            this.labelMostComments.AutoSize = true;
            this.labelMostComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostComments.Location = new System.Drawing.Point(690, 435);
            this.labelMostComments.Name = "labelMostComments";
            this.labelMostComments.Size = new System.Drawing.Size(129, 20);
            this.labelMostComments.TabIndex = 66;
            this.labelMostComments.Text = "Most Comments:";
            // 
            // labelMostLikedPhoto
            // 
            this.labelMostLikedPhoto.AutoSize = true;
            this.labelMostLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPhoto.Location = new System.Drawing.Point(533, 435);
            this.labelMostLikedPhoto.Name = "labelMostLikedPhoto";
            this.labelMostLikedPhoto.Size = new System.Drawing.Size(90, 20);
            this.labelMostLikedPhoto.TabIndex = 67;
            this.labelMostLikedPhoto.Text = "Most Liked:";
            // 
            // pictureBoxMostLiked
            // 
            this.pictureBoxMostLiked.Enabled = false;
            this.pictureBoxMostLiked.Location = new System.Drawing.Point(499, 458);
            this.pictureBoxMostLiked.Name = "pictureBoxMostLiked";
            this.pictureBoxMostLiked.Size = new System.Drawing.Size(164, 162);
            this.pictureBoxMostLiked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLiked.TabIndex = 68;
            this.pictureBoxMostLiked.TabStop = false;
            // 
            // pictureBoxMostComments
            // 
            this.pictureBoxMostComments.Enabled = false;
            this.pictureBoxMostComments.Location = new System.Drawing.Point(669, 458);
            this.pictureBoxMostComments.Name = "pictureBoxMostComments";
            this.pictureBoxMostComments.Size = new System.Drawing.Size(164, 162);
            this.pictureBoxMostComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostComments.TabIndex = 69;
            this.pictureBoxMostComments.TabStop = false;
            // 
            // labelPhotoDetails
            // 
            this.labelPhotoDetails.AutoSize = true;
            this.labelPhotoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoDetails.Location = new System.Drawing.Point(599, 286);
            this.labelPhotoDetails.Name = "labelPhotoDetails";
            this.labelPhotoDetails.Size = new System.Drawing.Size(131, 20);
            this.labelPhotoDetails.TabIndex = 70;
            this.labelPhotoDetails.Text = "Photos Details:";
            // 
            // labelTotalLikes
            // 
            this.labelTotalLikes.AutoSize = true;
            this.labelTotalLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLikes.Location = new System.Drawing.Point(533, 333);
            this.labelTotalLikes.Name = "labelTotalLikes";
            this.labelTotalLikes.Size = new System.Drawing.Size(89, 20);
            this.labelTotalLikes.TabIndex = 71;
            this.labelTotalLikes.Text = "Total Likes:";
            // 
            // labelTotalComments
            // 
            this.labelTotalComments.AutoSize = true;
            this.labelTotalComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalComments.Location = new System.Drawing.Point(533, 373);
            this.labelTotalComments.Name = "labelTotalComments";
            this.labelTotalComments.Size = new System.Drawing.Size(129, 20);
            this.labelTotalComments.TabIndex = 72;
            this.labelTotalComments.Text = "Total Comments:";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Click to open photo in facebook";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 657);
            this.Controls.Add(this.labelTotalComments);
            this.Controls.Add(this.labelTotalLikes);
            this.Controls.Add(this.labelPhotoDetails);
            this.Controls.Add(this.pictureBoxMostComments);
            this.Controls.Add(this.pictureBoxMostLiked);
            this.Controls.Add(this.labelMostLikedPhoto);
            this.Controls.Add(this.labelMostComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFetchPhotosLikes);
            this.Controls.Add(this.listBoxFrinends);
            this.Controls.Add(this.labelFirendsList);
            this.Controls.Add(this.labelFriendsNumber);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBoxProfileImage);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelFriendsNumber;
        private System.Windows.Forms.Label labelFirendsList;
        private System.Windows.Forms.ListBox listBoxFrinends;
        private System.Windows.Forms.Button buttonFetchPhotosLikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMostComments;
        private System.Windows.Forms.Label labelMostLikedPhoto;
        private System.Windows.Forms.PictureBox pictureBoxMostLiked;
        private System.Windows.Forms.PictureBox pictureBoxMostComments;
        private System.Windows.Forms.Label labelPhotoDetails;
        private System.Windows.Forms.Label labelTotalLikes;
        private System.Windows.Forms.Label labelTotalComments;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

