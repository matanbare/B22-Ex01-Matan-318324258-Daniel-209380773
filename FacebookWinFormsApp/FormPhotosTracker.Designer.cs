
namespace BasicFacebookFeatures
{
    partial class FormPhotosTracker
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
            this.labelTotalComments = new System.Windows.Forms.Label();
            this.labelTotalLikes = new System.Windows.Forms.Label();
            this.labelPhotoDetails = new System.Windows.Forms.Label();
            this.labelMostLikedPhoto = new System.Windows.Forms.Label();
            this.labelMostComments = new System.Windows.Forms.Label();
            this.buttonFetchCommentsTheMost = new System.Windows.Forms.Button();
            this.labelBestFriendLikes = new System.Windows.Forms.Label();
            this.labelBestFriendComment = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBestFriendsComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxBestFriendsLikes = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostLiked = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriendsComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBestFriendsLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalComments
            // 
            this.labelTotalComments.AutoSize = true;
            this.labelTotalComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalComments.Location = new System.Drawing.Point(514, 22);
            this.labelTotalComments.Name = "labelTotalComments";
            this.labelTotalComments.Size = new System.Drawing.Size(129, 20);
            this.labelTotalComments.TabIndex = 80;
            this.labelTotalComments.Text = "Total Comments:";
            // 
            // labelTotalLikes
            // 
            this.labelTotalLikes.AutoSize = true;
            this.labelTotalLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLikes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTotalLikes.Location = new System.Drawing.Point(332, 22);
            this.labelTotalLikes.Name = "labelTotalLikes";
            this.labelTotalLikes.Size = new System.Drawing.Size(89, 20);
            this.labelTotalLikes.TabIndex = 79;
            this.labelTotalLikes.Text = "Total Likes:";
            // 
            // labelPhotoDetails
            // 
            this.labelPhotoDetails.AutoSize = true;
            this.labelPhotoDetails.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoDetails.Location = new System.Drawing.Point(26, 9);
            this.labelPhotoDetails.Name = "labelPhotoDetails";
            this.labelPhotoDetails.Size = new System.Drawing.Size(230, 33);
            this.labelPhotoDetails.TabIndex = 78;
            this.labelPhotoDetails.Text = "Tracker Photos:";
            // 
            // labelMostLikedPhoto
            // 
            this.labelMostLikedPhoto.AutoSize = true;
            this.labelMostLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPhoto.Location = new System.Drawing.Point(28, 58);
            this.labelMostLikedPhoto.Name = "labelMostLikedPhoto";
            this.labelMostLikedPhoto.Size = new System.Drawing.Size(90, 20);
            this.labelMostLikedPhoto.TabIndex = 75;
            this.labelMostLikedPhoto.Text = "Most Liked:";
            // 
            // labelMostComments
            // 
            this.labelMostComments.AutoSize = true;
            this.labelMostComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostComments.Location = new System.Drawing.Point(408, 58);
            this.labelMostComments.Name = "labelMostComments";
            this.labelMostComments.Size = new System.Drawing.Size(129, 20);
            this.labelMostComments.TabIndex = 74;
            this.labelMostComments.Text = "Most Comments:";
            // 
            // buttonFetchCommentsTheMost
            // 
            this.buttonFetchCommentsTheMost.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonFetchCommentsTheMost.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchCommentsTheMost.ForeColor = System.Drawing.Color.Black;
            this.buttonFetchCommentsTheMost.Location = new System.Drawing.Point(455, 631);
            this.buttonFetchCommentsTheMost.Name = "buttonFetchCommentsTheMost";
            this.buttonFetchCommentsTheMost.Size = new System.Drawing.Size(180, 30);
            this.buttonFetchCommentsTheMost.TabIndex = 73;
            this.buttonFetchCommentsTheMost.Text = "Fetch";
            this.buttonFetchCommentsTheMost.UseVisualStyleBackColor = false;
            this.buttonFetchCommentsTheMost.Click += new System.EventHandler(this.buttonFetchPhotosLikes_Click);
            // 
            // labelBestFriendLikes
            // 
            this.labelBestFriendLikes.AutoSize = true;
            this.labelBestFriendLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriendLikes.Location = new System.Drawing.Point(29, 362);
            this.labelBestFriendLikes.Name = "labelBestFriendLikes";
            this.labelBestFriendLikes.Size = new System.Drawing.Size(145, 20);
            this.labelBestFriendLikes.TabIndex = 81;
            this.labelBestFriendLikes.Text = "Likes you the most:";
            // 
            // labelBestFriendComment
            // 
            this.labelBestFriendComment.AutoSize = true;
            this.labelBestFriendComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBestFriendComment.Location = new System.Drawing.Point(409, 362);
            this.labelBestFriendComment.Name = "labelBestFriendComment";
            this.labelBestFriendComment.Size = new System.Drawing.Size(185, 20);
            this.labelBestFriendComment.TabIndex = 82;
            this.labelBestFriendComment.Text = "Comments you the most:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BasicFacebookFeatures.Properties.Resources.comment_icon;
            this.pictureBox2.Location = new System.Drawing.Point(493, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.like_icon;
            this.pictureBox1.Location = new System.Drawing.Point(311, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxBestFriendsComments
            // 
            this.pictureBoxBestFriendsComments.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBestFriendsComments.Enabled = false;
            this.pictureBoxBestFriendsComments.Location = new System.Drawing.Point(413, 385);
            this.pictureBoxBestFriendsComments.Name = "pictureBoxBestFriendsComments";
            this.pictureBoxBestFriendsComments.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxBestFriendsComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriendsComments.TabIndex = 84;
            this.pictureBoxBestFriendsComments.TabStop = false;
            // 
            // pictureBoxBestFriendsLikes
            // 
            this.pictureBoxBestFriendsLikes.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBestFriendsLikes.Enabled = false;
            this.pictureBoxBestFriendsLikes.Location = new System.Drawing.Point(32, 385);
            this.pictureBoxBestFriendsLikes.Name = "pictureBoxBestFriendsLikes";
            this.pictureBoxBestFriendsLikes.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxBestFriendsLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBestFriendsLikes.TabIndex = 83;
            this.pictureBoxBestFriendsLikes.TabStop = false;
            // 
            // pictureBoxMostComments
            // 
            this.pictureBoxMostComments.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMostComments.Enabled = false;
            this.pictureBoxMostComments.Location = new System.Drawing.Point(413, 81);
            this.pictureBoxMostComments.Name = "pictureBoxMostComments";
            this.pictureBoxMostComments.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxMostComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostComments.TabIndex = 77;
            this.pictureBoxMostComments.TabStop = false;
            // 
            // pictureBoxMostLiked
            // 
            this.pictureBoxMostLiked.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMostLiked.Enabled = false;
            this.pictureBoxMostLiked.Location = new System.Drawing.Point(33, 81);
            this.pictureBoxMostLiked.Name = "pictureBoxMostLiked";
            this.pictureBoxMostLiked.Size = new System.Drawing.Size(280, 240);
            this.pictureBoxMostLiked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLiked.TabIndex = 76;
            this.pictureBoxMostLiked.TabStop = false;
            this.pictureBoxMostLiked.Click += new System.EventHandler(this.pictureBoxMostLiked_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(76, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 30);
            this.button1.TabIndex = 87;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(455, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 30);
            this.button2.TabIndex = 88;
            this.button2.Text = "Fetch";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PeachPuff;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(76, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 30);
            this.button3.TabIndex = 89;
            this.button3.Text = "Fetch";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormPhotosTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.facebookBackgroundApp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 673);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxBestFriendsComments);
            this.Controls.Add(this.pictureBoxBestFriendsLikes);
            this.Controls.Add(this.labelBestFriendComment);
            this.Controls.Add(this.labelBestFriendLikes);
            this.Controls.Add(this.labelTotalComments);
            this.Controls.Add(this.labelTotalLikes);
            this.Controls.Add(this.labelPhotoDetails);
            this.Controls.Add(this.pictureBoxMostComments);
            this.Controls.Add(this.pictureBoxMostLiked);
            this.Controls.Add(this.labelMostLikedPhoto);
            this.Controls.Add(this.labelMostComments);
            this.Controls.Add(this.buttonFetchCommentsTheMost);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormPhotosTracker";
            this.Text = "FormPhotosTracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button buttonFetchCommentsTheMost;
        private System.Windows.Forms.Label labelBestFriendLikes;
        private System.Windows.Forms.Label labelBestFriendComment;
        private System.Windows.Forms.PictureBox pictureBoxBestFriendsLikes;
        private System.Windows.Forms.PictureBox pictureBoxBestFriendsComments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}