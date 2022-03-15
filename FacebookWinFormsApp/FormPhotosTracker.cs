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
            if (!string.IsNullOrEmpty(PhotosDetails.MostCommentsPhotoUrl))
            {
                pictureBoxMostComments.LoadAsync(PhotosDetails.MostCommentsPhotoUrl);
                pictureBoxMostComments.Enabled = true;
                labelMostComments.Text += PhotosDetails.MostCommentsPhoto;
            }
            else
            {
                labelMostComments.Text = $"User doesn't have photos";
            }
        }

        private void setMostLikesPicture()
        {
            if (!string.IsNullOrEmpty(PhotosDetails.MostLikedPhotoUrl))
            {
                pictureBoxMostLiked.LoadAsync(PhotosDetails.MostLikedPhotoUrl);
                pictureBoxMostLiked.Enabled = true;
                labelMostLikedPhoto.Text += PhotosDetails.MostLikedPhoto;
            }
            else
            {
                labelMostComments.Text = $"User doesn't have photos";
            }
        }

        private void setBestFriendComments()
        {
            string name = PhotosDetails.BestFriendComments(out int numberOfComments, out string profileImageUrl);
            if (!string.IsNullOrEmpty(name))
            {
                labelBestFriendComment.Text += $" {name} {numberOfComments}";
                pictureBoxBestFriendsComments.LoadAsync(profileImageUrl);
            }
            else
            {
                labelBestFriendComment.Text = $" No one comment on your photos";
            }
        }

        private void setBestFriendLikes()
        {
            string name = PhotosDetails.BestFriendsLikes(out int numberOfLikes, out string profileImageUrl);

            if (!string.IsNullOrEmpty(name))
            {
                labelBestFriendLikes.Text += $" {name} ({numberOfLikes})";
                pictureBoxBestFriendsLikes.LoadAsync(profileImageUrl);
            }
            else
            {
                labelBestFriendLikes.Text = $" No one like your photos";
            }
        }
    }
}
