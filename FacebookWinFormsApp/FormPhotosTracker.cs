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
        public UserPhotosDetails PhotosDetails { get; set; }

        public FormPhotosTracker(User i_LoggedInUser)
        {
            InitializeComponent();
            PhotosDetails = new UserPhotosDetails(i_LoggedInUser.Albums, i_LoggedInUser.Friends);

            setTotalComments();
            setTotalLikes();
            setMostCommentsPicture();
            setMostLikesPicture();
            setBestFriendComments();
            setBestFriendLikes();
        }

        private void setTotalComments()
        {
            labelTotalComments.Text = string.Format("Total Comments: {0}", PhotosDetails.TotalCommentsPhoto);
        }

        private void setTotalLikes()
        {
            labelTotalLikes.Text = string.Format("Total Likes: {0}", PhotosDetails.TotalLikesPhoto);
        }

        private void setMostCommentsPicture()
        {
            pictureBoxMostComments.LoadAsync(PhotosDetails.MostCommentsPhotoUrl);
            pictureBoxMostComments.Enabled = true;
            labelMostComments.Text += PhotosDetails.MostCommentsPhoto;
        }

        private void setMostLikesPicture()
        {
            pictureBoxMostLiked.LoadAsync(PhotosDetails.MostLikedPhotoUrl);
            pictureBoxMostLiked.Enabled = true;
            labelMostLikedPhoto.Text += PhotosDetails.MostLikedPhoto;
        }

        private void setBestFriendComments()
        {
            string name = PhotosDetails.BestFriendComments(out int numberOfComments, out string profileImageUrl);

            labelBestFriendComment.Text += $" {name} {numberOfComments}";
            pictureBoxBestFriendsComments.LoadAsync(profileImageUrl);
        }

        private void setBestFriendLikes()
        {
            string name = PhotosDetails.BestFriendsLikes(out int numberOfLikes, out string profileImageUrl);

            labelBestFriendLikes.Text += $" {name} {numberOfLikes}";
            pictureBoxBestFriendsLikes.LoadAsync(profileImageUrl);
        }
    }
}
