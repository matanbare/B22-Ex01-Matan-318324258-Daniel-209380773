
namespace BasicFacebookFeatures
{
    partial class Feature1
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
            this.pictureBoxMostComments = new System.Windows.Forms.PictureBox();
            this.pictureBoxMostLiked = new System.Windows.Forms.PictureBox();
            this.labelMostLikedPhoto = new System.Windows.Forms.Label();
            this.labelMostComments = new System.Windows.Forms.Label();
            this.buttonFetchPhotosLikes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLiked)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalComments
            // 
            this.labelTotalComments.AutoSize = true;
            this.labelTotalComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalComments.Location = new System.Drawing.Point(285, 159);
            this.labelTotalComments.Name = "labelTotalComments";
            this.labelTotalComments.Size = new System.Drawing.Size(129, 20);
            this.labelTotalComments.TabIndex = 80;
            this.labelTotalComments.Text = "Total Comments:";
            // 
            // labelTotalLikes
            // 
            this.labelTotalLikes.AutoSize = true;
            this.labelTotalLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalLikes.Location = new System.Drawing.Point(285, 128);
            this.labelTotalLikes.Name = "labelTotalLikes";
            this.labelTotalLikes.Size = new System.Drawing.Size(89, 20);
            this.labelTotalLikes.TabIndex = 79;
            this.labelTotalLikes.Text = "Total Likes:";
            // 
            // labelPhotoDetails
            // 
            this.labelPhotoDetails.AutoSize = true;
            this.labelPhotoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhotoDetails.Location = new System.Drawing.Point(333, 72);
            this.labelPhotoDetails.Name = "labelPhotoDetails";
            this.labelPhotoDetails.Size = new System.Drawing.Size(131, 20);
            this.labelPhotoDetails.TabIndex = 78;
            this.labelPhotoDetails.Text = "Photos Details:";
            // 
            // pictureBoxMostComments
            // 
            this.pictureBoxMostComments.Enabled = false;
            this.pictureBoxMostComments.Location = new System.Drawing.Point(403, 244);
            this.pictureBoxMostComments.Name = "pictureBoxMostComments";
            this.pictureBoxMostComments.Size = new System.Drawing.Size(164, 159);
            this.pictureBoxMostComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostComments.TabIndex = 77;
            this.pictureBoxMostComments.TabStop = false;
            // 
            // pictureBoxMostLiked
            // 
            this.pictureBoxMostLiked.Enabled = false;
            this.pictureBoxMostLiked.Location = new System.Drawing.Point(233, 244);
            this.pictureBoxMostLiked.Name = "pictureBoxMostLiked";
            this.pictureBoxMostLiked.Size = new System.Drawing.Size(164, 159);
            this.pictureBoxMostLiked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostLiked.TabIndex = 76;
            this.pictureBoxMostLiked.TabStop = false;
            // 
            // labelMostLikedPhoto
            // 
            this.labelMostLikedPhoto.AutoSize = true;
            this.labelMostLikedPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostLikedPhoto.Location = new System.Drawing.Point(267, 221);
            this.labelMostLikedPhoto.Name = "labelMostLikedPhoto";
            this.labelMostLikedPhoto.Size = new System.Drawing.Size(90, 20);
            this.labelMostLikedPhoto.TabIndex = 75;
            this.labelMostLikedPhoto.Text = "Most Liked:";
            // 
            // labelMostComments
            // 
            this.labelMostComments.AutoSize = true;
            this.labelMostComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostComments.Location = new System.Drawing.Point(424, 221);
            this.labelMostComments.Name = "labelMostComments";
            this.labelMostComments.Size = new System.Drawing.Size(129, 20);
            this.labelMostComments.TabIndex = 74;
            this.labelMostComments.Text = "Most Comments:";
            // 
            // buttonFetchPhotosLikes
            // 
            this.buttonFetchPhotosLikes.Location = new System.Drawing.Point(325, 44);
            this.buttonFetchPhotosLikes.Name = "buttonFetchPhotosLikes";
            this.buttonFetchPhotosLikes.Size = new System.Drawing.Size(145, 20);
            this.buttonFetchPhotosLikes.TabIndex = 73;
            this.buttonFetchPhotosLikes.Text = "Fetch";
            this.buttonFetchPhotosLikes.UseVisualStyleBackColor = true;
            this.buttonFetchPhotosLikes.Click += new System.EventHandler(this.buttonFetchPhotosLikes_Click);
            // 
            // Feature1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalComments);
            this.Controls.Add(this.labelTotalLikes);
            this.Controls.Add(this.labelPhotoDetails);
            this.Controls.Add(this.pictureBoxMostComments);
            this.Controls.Add(this.pictureBoxMostLiked);
            this.Controls.Add(this.labelMostLikedPhoto);
            this.Controls.Add(this.labelMostComments);
            this.Controls.Add(this.buttonFetchPhotosLikes);
            this.Name = "Feature1";
            this.Text = "Feature1";
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
        private System.Windows.Forms.Button buttonFetchPhotosLikes;
    }
}