using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.Properties;

namespace BasicFacebookFeatures
{
    public partial class FormPhotosDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPhotosDetails));
            this.labelTotalComments = new Label();
            this.labelTotalLikes = new Label();
            this.labelPhotoDetails = new Label();
            this.labelMostLikedPhoto = new Label();
            this.labelMostComments = new Label();
            this.labelBestFriendLikes = new Label();
            this.labelBestFriendComment = new Label();
            this.pictureBoxTotalCommentsIclon = new PictureBox();
            this.pictureBoxLikeTotalIcon = new PictureBox();
            this.pictureBoxBestFriendsComments = new PictureBox();
            this.pictureBoxBestFriendsLikes = new PictureBox();
            this.pictureBoxMostComments = new PictureBox();
            this.pictureBoxMostLiked = new PictureBox();
            ((ISupportInitialize)(this.pictureBoxTotalCommentsIclon)).BeginInit();
            ((ISupportInitialize)(this.pictureBoxLikeTotalIcon)).BeginInit();
            ((ISupportInitialize)(this.pictureBoxBestFriendsComments)).BeginInit();
            ((ISupportInitialize)(this.pictureBoxBestFriendsLikes)).BeginInit();
            ((ISupportInitialize)(this.pictureBoxMostComments)).BeginInit();
            ((ISupportInitialize)(this.pictureBoxMostLiked)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalComments
            // 
            this.labelTotalComments.AutoSize = true;
            this.labelTotalComments.BackColor = Color.Transparent;
            this.labelTotalComments.Font = new Font("Microsoft Sans Serif", 14.25F, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalComments.ForeColor = Color.Transparent;
            this.labelTotalComments.Location = new Point(631, 43);
            this.labelTotalComments.Margin = new Padding(4, 0, 4, 0);
            this.labelTotalComments.Name = "labelTotalComments";
            this.labelTotalComments.Size = new Size(167, 24);
            this.labelTotalComments.TabIndex = 80;
            this.labelTotalComments.Text = "Total Comments:";
            // 
            // labelTotalLikes
            // 
            this.labelTotalLikes.AutoSize = true;
            this.labelTotalLikes.BackColor = Color.Transparent;
            this.labelTotalLikes.Font = new Font("Microsoft Sans Serif", 14.25F, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLikes.ForeColor = Color.Transparent;
            this.labelTotalLikes.ImageAlign = ContentAlignment.MiddleLeft;
            this.labelTotalLikes.Location = new Point(418, 43);
            this.labelTotalLikes.Margin = new Padding(4, 0, 4, 0);
            this.labelTotalLikes.Name = "labelTotalLikes";
            this.labelTotalLikes.Size = new Size(116, 24);
            this.labelTotalLikes.TabIndex = 79;
            this.labelTotalLikes.Text = "Total Likes:";
            // 
            // labelPhotoDetails
            // 
            this.labelPhotoDetails.AutoSize = true;
            this.labelPhotoDetails.BackColor = Color.Transparent;
            this.labelPhotoDetails.Font = new Font("Tahoma", 27.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoDetails.ForeColor = Color.White;
            this.labelPhotoDetails.Location = new Point(57, 25);
            this.labelPhotoDetails.Margin = new Padding(4, 0, 4, 0);
            this.labelPhotoDetails.Name = "labelPhotoDetails";
            this.labelPhotoDetails.Size = new Size(313, 45);
            this.labelPhotoDetails.TabIndex = 78;
            this.labelPhotoDetails.Text = "Tracker Photos:";
            // 
            // labelMostLikedPhoto
            // 
            this.labelMostLikedPhoto.AutoSize = true;
            this.labelMostLikedPhoto.BackColor = Color.Transparent;
            this.labelMostLikedPhoto.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPhoto.ForeColor = Color.White;
            this.labelMostLikedPhoto.Location = new Point(105, 86);
            this.labelMostLikedPhoto.Margin = new Padding(4, 0, 4, 0);
            this.labelMostLikedPhoto.Name = "labelMostLikedPhoto";
            this.labelMostLikedPhoto.Size = new Size(123, 25);
            this.labelMostLikedPhoto.TabIndex = 75;
            this.labelMostLikedPhoto.Text = "Most Liked:";
            // 
            // labelMostComments
            // 
            this.labelMostComments.AutoSize = true;
            this.labelMostComments.BackColor = Color.Transparent;
            this.labelMostComments.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
            this.labelMostComments.ForeColor = Color.White;
            this.labelMostComments.Location = new Point(533, 86);
            this.labelMostComments.Margin = new Padding(4, 0, 4, 0);
            this.labelMostComments.Name = "labelMostComments";
            this.labelMostComments.Size = new Size(173, 25);
            this.labelMostComments.TabIndex = 74;
            this.labelMostComments.Text = "Most Comments:";
            // 
            // labelBestFriendLikes
            // 
            this.labelBestFriendLikes.AutoSize = true;
            this.labelBestFriendLikes.BackColor = Color.Transparent;
            this.labelBestFriendLikes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriendLikes.ForeColor = Color.White;
            this.labelBestFriendLikes.Location = new Point(105, 395);
            this.labelBestFriendLikes.Margin = new Padding(4, 0, 4, 0);
            this.labelBestFriendLikes.Name = "labelBestFriendLikes";
            this.labelBestFriendLikes.Size = new Size(198, 25);
            this.labelBestFriendLikes.TabIndex = 81;
            this.labelBestFriendLikes.Text = "Likes you the most:";
            // 
            // labelBestFriendComment
            // 
            this.labelBestFriendComment.AutoSize = true;
            this.labelBestFriendComment.BackColor = Color.Transparent;
            this.labelBestFriendComment.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriendComment.ForeColor = Color.White;
            this.labelBestFriendComment.Location = new Point(533, 395);
            this.labelBestFriendComment.Margin = new Padding(4, 0, 4, 0);
            this.labelBestFriendComment.Name = "labelBestFriendComment";
            this.labelBestFriendComment.Size = new Size(249, 25);
            this.labelBestFriendComment.TabIndex = 82;
            this.labelBestFriendComment.Text = "Comments you the most:";
            // 
            // pictureBoxTotalCommentsIclon
            // 
            this.pictureBoxTotalCommentsIclon.BackColor = Color.Transparent;
            this.pictureBoxTotalCommentsIclon.Image = Resources.comment_icon;
            this.pictureBoxTotalCommentsIclon.Location = new Point(607, 43);
            this.pictureBoxTotalCommentsIclon.Margin = new Padding(4, 5, 4, 5);
            this.pictureBoxTotalCommentsIclon.Name = "pictureBoxTotalCommentsIclon";
            this.pictureBoxTotalCommentsIclon.Size = new Size(25, 25);
            this.pictureBoxTotalCommentsIclon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxTotalCommentsIclon.TabIndex = 86;
            this.pictureBoxTotalCommentsIclon.TabStop = false;
            // 
            // pictureBoxLikeTotalIcon
            // 
            this.pictureBoxLikeTotalIcon.BackColor = Color.Transparent;
            this.pictureBoxLikeTotalIcon.Image = Resources.like_icon;
            this.pictureBoxLikeTotalIcon.Location = new Point(385, 43);
            this.pictureBoxLikeTotalIcon.Margin = new Padding(4, 5, 4, 5);
            this.pictureBoxLikeTotalIcon.Name = "pictureBoxLikeTotalIcon";
            this.pictureBoxLikeTotalIcon.Size = new Size(25, 25);
            this.pictureBoxLikeTotalIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikeTotalIcon.TabIndex = 85;
            this.pictureBoxLikeTotalIcon.TabStop = false;
            // 
            // pictureBoxBestFriendsComments
            // 
            this.pictureBoxBestFriendsComments.BackColor = Color.Transparent;
            this.pictureBoxBestFriendsComments.Enabled = false;
            this.pictureBoxBestFriendsComments.Location = new Point(538, 444);
            this.pictureBoxBestFriendsComments.Margin = new Padding(4, 5, 4, 5);
            this.pictureBoxBestFriendsComments.Name = "pictureBoxBestFriendsComments";
            this.pictureBoxBestFriendsComments.Size = new Size(260, 250);
            this.pictureBoxBestFriendsComments.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriendsComments.TabIndex = 84;
            this.pictureBoxBestFriendsComments.TabStop = false;
            // 
            // pictureBoxBestFriendsLikes
            // 
            this.pictureBoxBestFriendsLikes.BackColor = Color.Transparent;
            this.pictureBoxBestFriendsLikes.Enabled = false;
            this.pictureBoxBestFriendsLikes.Location = new Point(110, 444);
            this.pictureBoxBestFriendsLikes.Margin = new Padding(4, 5, 4, 5);
            this.pictureBoxBestFriendsLikes.Name = "pictureBoxBestFriendsLikes";
            this.pictureBoxBestFriendsLikes.Size = new Size(260, 250);
            this.pictureBoxBestFriendsLikes.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriendsLikes.TabIndex = 83;
            this.pictureBoxBestFriendsLikes.TabStop = false;
            // 
            // pictureBoxMostComments
            // 
            this.pictureBoxMostComments.BackColor = Color.Transparent;
            this.pictureBoxMostComments.Enabled = false;
            this.pictureBoxMostComments.Location = new Point(538, 130);
            this.pictureBoxMostComments.Margin = new Padding(4, 5, 4, 5);
            this.pictureBoxMostComments.Name = "pictureBoxMostComments";
            this.pictureBoxMostComments.Size = new Size(260, 250);
            this.pictureBoxMostComments.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostComments.TabIndex = 77;
            this.pictureBoxMostComments.TabStop = false;
            // 
            // pictureBoxMostLiked
            // 
            this.pictureBoxMostLiked.BackColor = Color.Transparent;
            this.pictureBoxMostLiked.Enabled = false;
            this.pictureBoxMostLiked.Location = new Point(110, 130);
            this.pictureBoxMostLiked.Margin = new Padding(4, 5, 4, 5);
            this.pictureBoxMostLiked.Name = "pictureBoxMostLiked";
            this.pictureBoxMostLiked.Size = new Size(260, 250);
            this.pictureBoxMostLiked.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLiked.TabIndex = 76;
            this.pictureBoxMostLiked.TabStop = false;
            // 
            // FormPhotosDetails
            // 
            this.AutoScaleDimensions = new SizeF(10F, 19F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = SystemColors.ButtonHighlight;
            this.BackgroundImage = Resources.photoTrackerBackground1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ClientSize = new Size(963, 708);
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
            this.Font = new Font("Tahoma", 12F, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new Size(1048, 747);
            this.Name = "FormPhotosDetails";
            this.Text = "Photos Tracker";
            ((ISupportInitialize)(this.pictureBoxTotalCommentsIclon)).EndInit();
            ((ISupportInitialize)(this.pictureBoxLikeTotalIcon)).EndInit();
            ((ISupportInitialize)(this.pictureBoxBestFriendsComments)).EndInit();
            ((ISupportInitialize)(this.pictureBoxBestFriendsLikes)).EndInit();
            ((ISupportInitialize)(this.pictureBoxMostComments)).EndInit();
            ((ISupportInitialize)(this.pictureBoxMostLiked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTotalComments;
        private Label labelTotalLikes;
        private Label labelPhotoDetails;
        private PictureBox pictureBoxMostComments;
        private PictureBox pictureBoxMostLiked;
        private Label labelMostLikedPhoto;
        private Label labelMostComments;
        private Label labelBestFriendLikes;
        private Label labelBestFriendComment;
        private PictureBox pictureBoxBestFriendsLikes;
        private PictureBox pictureBoxBestFriendsComments;
        private PictureBox pictureBoxLikeTotalIcon;
        private PictureBox pictureBoxTotalCommentsIclon;
    }
}