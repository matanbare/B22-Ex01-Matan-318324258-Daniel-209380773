using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPhotosTracker : Form
    {
        public UserPhotosTracker PhotosTracker { get; set; }

        public FormPhotosTracker(User i_LoggedInUser)
        {
            InitializeComponent();
            PhotosTracker = new UserPhotosTracker(i_LoggedInUser.Albums, i_LoggedInUser.Friends);
        }

        private void buttonFetchPhotosLikes_Click(object sender, EventArgs e)
        {
            setTotalLikesAndComments();
            setMostCommentsPicture();
            setMostLikesPicture();
            setBestFriendComments();
            setBestFriendLikes();
        }

        private void setTotalLikesAndComments()
        {
            labelTotalLikes.Text = string.Format("Total Likes: {0}", PhotosTracker.TotalLikesPhoto);
            labelTotalComments.Text = string.Format("Total Comments: {0}", PhotosTracker.TotalCommentsPhoto);

        }

        private void setMostCommentsPicture()
        {
            pictureBoxMostComments.LoadAsync(PhotosTracker.MostCommentsPhotoUrl);
            pictureBoxMostComments.Enabled = true;
        }

        private void setMostLikesPicture()
        {
            pictureBoxMostLiked.LoadAsync(PhotosTracker.MostLikedPhotoUrl);
            pictureBoxMostLiked.Enabled = true;
        }

        private void setBestFriendComments()
        {
            string name = PhotosTracker.BestFriendComments(out int numberOfComments, out string profileImageUrl);

            labelBestFriendComment.Text += $" {name} {numberOfComments}";
            pictureBoxBestFriendsComments.LoadAsync(profileImageUrl);
        }

        private void setBestFriendLikes()
        {
            string name = PhotosTracker.BestFriendComments(out int numberOfLikes, out string profileImageUrl);

            labelBestFriendLikes.Text += $" {name} {numberOfLikes}";
            pictureBoxBestFriendsLikes.LoadAsync(profileImageUrl);
        }

        private void pictureBoxMostLiked_Click(object sender, EventArgs e)
        {
        }

        private void linkLabelMostLiked_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}
