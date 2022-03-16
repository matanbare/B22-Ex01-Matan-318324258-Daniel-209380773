namespace BasicFacebookFeatures
{
    public partial class FormPhotosDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhotosDetails));
            this.labelTotalComments = new System.Windows.Forms.Label();
            this.labelTotalLikes = new System.Windows.Forms.Label();
            this.labelPhotoDetails = new System.Windows.Forms.Label();
            this.labelMostLikedPhoto = new System.Windows.Forms.Label();
            this.labelMostComments = new System.Windows.Forms.Label();
            this.labelBestFriendLikes = new System.Windows.Forms.Label();
            this.labelBestFriendComment = new System.Windows.Forms.Label();
            this.pictureBoxTotalCommentsIclon = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikeTotalIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxBestFriendsComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxBestFriendsLikes = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostLiked = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalCommentsIclon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikeTotalIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriendsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriendsLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalComments
            // 
            this.labelTotalComments.AutoSize = true;
            this.labelTotalComments.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalComments.ForeColor = System.Drawing.Color.Transparent;
            this.labelTotalComments.Location = new System.Drawing.Point(631, 43);
            this.labelTotalComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalComments.Name = "labelTotalComments";
            this.labelTotalComments.Size = new System.Drawing.Size(167, 24);
            this.labelTotalComments.TabIndex = 80;
            this.labelTotalComments.Text = "Total Comments:";
            // 
            // labelTotalLikes
            // 
            this.labelTotalLikes.AutoSize = true;
            this.labelTotalLikes.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLikes.ForeColor = System.Drawing.Color.Transparent;
            this.labelTotalLikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalLikes.Location = new System.Drawing.Point(418, 43);
            this.labelTotalLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalLikes.Name = "labelTotalLikes";
            this.labelTotalLikes.Size = new System.Drawing.Size(116, 24);
            this.labelTotalLikes.TabIndex = 79;
            this.labelTotalLikes.Text = "Total Likes:";
            // 
            // labelPhotoDetails
            // 
            this.labelPhotoDetails.AutoSize = true;
            this.labelPhotoDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelPhotoDetails.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoDetails.ForeColor = System.Drawing.Color.White;
            this.labelPhotoDetails.Location = new System.Drawing.Point(57, 25);
            this.labelPhotoDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhotoDetails.Name = "labelPhotoDetails";
            this.labelPhotoDetails.Size = new System.Drawing.Size(313, 45);
            this.labelPhotoDetails.TabIndex = 78;
            this.labelPhotoDetails.Text = "Tracker Photos:";
            // 
            // labelMostLikedPhoto
            // 
            this.labelMostLikedPhoto.AutoSize = true;
            this.labelMostLikedPhoto.BackColor = System.Drawing.Color.Transparent;
            this.labelMostLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPhoto.ForeColor = System.Drawing.Color.White;
            this.labelMostLikedPhoto.Location = new System.Drawing.Point(105, 86);
            this.labelMostLikedPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostLikedPhoto.Name = "labelMostLikedPhoto";
            this.labelMostLikedPhoto.Size = new System.Drawing.Size(123, 25);
            this.labelMostLikedPhoto.TabIndex = 75;
            this.labelMostLikedPhoto.Text = "Most Liked:";
            // 
            // labelMostComments
            // 
            this.labelMostComments.AutoSize = true;
            this.labelMostComments.BackColor = System.Drawing.Color.Transparent;
            this.labelMostComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostComments.ForeColor = System.Drawing.Color.White;
            this.labelMostComments.Location = new System.Drawing.Point(533, 86);
            this.labelMostComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMostComments.Name = "labelMostComments";
            this.labelMostComments.Size = new System.Drawing.Size(173, 25);
            this.labelMostComments.TabIndex = 74;
            this.labelMostComments.Text = "Most Comments:";
            // 
            // labelBestFriendLikes
            // 
            this.labelBestFriendLikes.AutoSize = true;
            this.labelBestFriendLikes.BackColor = System.Drawing.Color.Transparent;
            this.labelBestFriendLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriendLikes.ForeColor = System.Drawing.Color.White;
            this.labelBestFriendLikes.Location = new System.Drawing.Point(105, 395);
            this.labelBestFriendLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBestFriendLikes.Name = "labelBestFriendLikes";
            this.labelBestFriendLikes.Size = new System.Drawing.Size(198, 25);
            this.labelBestFriendLikes.TabIndex = 81;
            this.labelBestFriendLikes.Text = "Likes you the most:";
            // 
            // labelBestFriendComment
            // 
            this.labelBestFriendComment.AutoSize = true;
            this.labelBestFriendComment.BackColor = System.Drawing.Color.Transparent;
            this.labelBestFriendComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriendComment.ForeColor = System.Drawing.Color.White;
            this.labelBestFriendComment.Location = new System.Drawing.Point(533, 395);
            this.labelBestFriendComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBestFriendComment.Name = "labelBestFriendComment";
            this.labelBestFriendComment.Size = new System.Drawing.Size(249, 25);
            this.labelBestFriendComment.TabIndex = 82;
            this.labelBestFriendComment.Text = "Comments you the most:";
            // 
            // pictureBoxTotalCommentsIclon
            // 
            this.pictureBoxTotalCommentsIclon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTotalCommentsIclon.Image = global::BasicFacebookFeatures.Properties.Resources.comment_icon;
            this.pictureBoxTotalCommentsIclon.Location = new System.Drawing.Point(607, 43);
            this.pictureBoxTotalCommentsIclon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxTotalCommentsIclon.Name = "pictureBoxTotalCommentsIclon";
            this.pictureBoxTotalCommentsIclon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxTotalCommentsIclon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTotalCommentsIclon.TabIndex = 86;
            this.pictureBoxTotalCommentsIclon.TabStop = false;
            // 
            // pictureBoxLikeTotalIcon
            // 
            this.pictureBoxLikeTotalIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLikeTotalIcon.Image = global::BasicFacebookFeatures.Properties.Resources.like_icon;
            this.pictureBoxLikeTotalIcon.Location = new System.Drawing.Point(385, 43);
            this.pictureBoxLikeTotalIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLikeTotalIcon.Name = "pictureBoxLikeTotalIcon";
            this.pictureBoxLikeTotalIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxLikeTotalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikeTotalIcon.TabIndex = 85;
            this.pictureBoxLikeTotalIcon.TabStop = false;
            // 
            // pictureBoxBestFriendsComments
            // 
            this.pictureBoxBestFriendsComments.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBestFriendsComments.Enabled = false;
            this.pictureBoxBestFriendsComments.Location = new System.Drawing.Point(538, 444);
            this.pictureBoxBestFriendsComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxBestFriendsComments.Name = "pictureBoxBestFriendsComments";
            this.pictureBoxBestFriendsComments.Size = new System.Drawing.Size(260, 250);
            this.pictureBoxBestFriendsComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriendsComments.TabIndex = 84;
            this.pictureBoxBestFriendsComments.TabStop = false;
            // 
            // pictureBoxBestFriendsLikes
            // 
            this.pictureBoxBestFriendsLikes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBestFriendsLikes.Enabled = false;
            this.pictureBoxBestFriendsLikes.Location = new System.Drawing.Point(110, 444);
            this.pictureBoxBestFriendsLikes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxBestFriendsLikes.Name = "pictureBoxBestFriendsLikes";
            this.pictureBoxBestFriendsLikes.Size = new System.Drawing.Size(260, 250);
            this.pictureBoxBestFriendsLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriendsLikes.TabIndex = 83;
            this.pictureBoxBestFriendsLikes.TabStop = false;
            // 
            // pictureBoxMostComments
            // 
            this.pictureBoxMostComments.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMostComments.Enabled = false;
            this.pictureBoxMostComments.Location = new System.Drawing.Point(538, 130);
            this.pictureBoxMostComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxMostComments.Name = "pictureBoxMostComments";
            this.pictureBoxMostComments.Size = new System.Drawing.Size(260, 250);
            this.pictureBoxMostComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostComments.TabIndex = 77;
            this.pictureBoxMostComments.TabStop = false;
            // 
            // pictureBoxMostLiked
            // 
            this.pictureBoxMostLiked.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMostLiked.Enabled = false;
            this.pictureBoxMostLiked.Location = new System.Drawing.Point(110, 130);
            this.pictureBoxMostLiked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxMostLiked.Name = "pictureBoxMostLiked";
            this.pictureBoxMostLiked.Size = new System.Drawing.Size(260, 250);
            this.pictureBoxMostLiked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLiked.TabIndex = 76;
            this.pictureBoxMostLiked.TabStop = false;
            // 
            // FormPhotosDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.photoTrackerBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 708);
            this.Controls.Add(this.pictureBoxTotalCommentsIclon);
            this.Controls.Add(this.labelTotalLikes);
            this.Controls.Add(this.labelTotalComments);
            this.Controls.Add(this.pictureBoxLikeTotalIcon);
            this.Controls.Add(this.pictureBoxBestFriendsComments);
            this.Controls.Add(this.pictureBoxBestFriendsLikes);
            this.Controls.Add(this.labelBestFriendComment);
            this.Controls.Add(this.labelBestFriendLikes);
            this.Controls.Add(this.labelPhotoDetails);
            this.Controls.Add(this.pictureBoxMostComments);
            this.Controls.Add(this.pictureBoxMostLiked);
            this.Controls.Add(this.labelMostLikedPhoto);
            this.Controls.Add(this.labelMostComments);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1048, 747);
            this.Name = "FormPhotosDetails";
            this.Text = "Photos Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTotalCommentsIclon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikeTotalIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriendsComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriendsLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalComments;
        private System.Windows.Forms.Label labelTotalLikes;
        private System.Windows.Forms.Label labelPhotoDetails;
        private System.Windows.Forms.PictureBox pictureBoxMostComments;
        private System.Windows.Forms.PictureBox pictureBoxMostLiked;
        private System.Windows.Forms.Label labelMostLikedPhoto;
        private System.Windows.Forms.Label labelMostComments;
        private System.Windows.Forms.Label labelBestFriendLikes;
        private System.Windows.Forms.Label labelBestFriendComment;
        private System.Windows.Forms.PictureBox pictureBoxBestFriendsLikes;
        private System.Windows.Forms.PictureBox pictureBoxBestFriendsComments;
        private System.Windows.Forms.PictureBox pictureBoxLikeTotalIcon;
        private System.Windows.Forms.PictureBox pictureBoxTotalCommentsIclon;
    }
}