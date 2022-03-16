using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.ENums;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPhotosDetails : Form
    {
        private const string k_UserWithoutPhotos = "You haven't photos =(";

        public UserPhotosDetails PhotosDetails { get; set; }

        public FormPhotosDetails(User i_LoggedInUser)
        {
            InitializeComponent();
            PhotosDetails = new UserPhotosDetails(i_LoggedInUser.Albums, i_LoggedInUser.Friends);
            updateAllControls();
        }

        private void updateAllControls()
        {
            setTotalReactionsLabelText(labelTotalComments, $"Total Comments:{PhotosDetails.TotalCommentsPhoto}");
            setTotalReactionsLabelText(labelTotalLikes, $"Total Likes:{PhotosDetails.TotalLikesPhoto}");
            setMostReactionsPictureBox(labelMostComments, pictureBoxMostComments, PhotosDetails.MostCommentsPhotoUrl, PhotosDetails.MostCommentsPhoto);
            setMostReactionsPictureBox(labelMostLikedPhoto, pictureBoxMostLiked, PhotosDetails.MostLikedPhotoUrl, PhotosDetails.MostLikedPhoto);
            setBestFriendReactions(eTotalCount.Comments, out int numberOfComments, out string bestFriendPictureUrlComments, labelBestFriendComment, pictureBoxBestFriendsComments);
            setBestFriendReactions(eTotalCount.Comments, out int numberOfLikes, out string bestFriendPictureUrlLikes, labelBestFriendLikes, pictureBoxBestFriendsLikes);
        }

        private void setTotalReactionsLabelText(Label i_Label, string i_TextToShow)
        {
            i_Label.Text = i_TextToShow;
        }

        private void setMostReactionsPictureBox(Label i_Label, PictureBox i_PictureBox, string i_PictureUrl, int i_NumberOfReactions)
        {
            if (!string.IsNullOrEmpty(i_PictureUrl))
            {
                i_PictureBox.LoadAsync(i_PictureUrl);
                i_Label.Text += i_NumberOfReactions;
            }
            else
            {
                i_Label.Text = k_UserWithoutPhotos;
            }
        }

        private void setBestFriendReactions(eTotalCount i_TotalCount, out int i_NumberOfReactions, out string i_PictureUrl, Label i_Label, PictureBox i_PictureBox)
        {
            string name = PhotosDetails.GetBestFriendReactions(i_TotalCount, out i_NumberOfReactions, out i_PictureUrl);

            if (!string.IsNullOrEmpty(name))
            {
                i_Label.Text += $" {name} ({i_NumberOfReactions})";
                i_PictureBox.LoadAsync(i_PictureUrl);
            }
            else
            {
                i_Label.Text = k_UserWithoutPhotos;
            }
        }
    }
}
