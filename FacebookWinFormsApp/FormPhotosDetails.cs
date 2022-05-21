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
    public partial class FormPhotosDetails : Form, IScreen
    {
        private const string k_UserWithoutPhotos = "You haven't photos =(";
        private static bool isFeatureLoad = false;

        public FacadeLogicManager FacadeLogicManager { get; }

        public FormPhotosDetails(FacadeLogicManager i_FacadeLogicManager)
        {
            InitializeComponent();
            FacadeLogicManager = i_FacadeLogicManager;
        }

        private void updateAllControls()
        {
            setTotalReactionsLabelText(labelTotalComments, $"Total Comments:{FacadeLogicManager.UserPhotosDetails.TotalCommentsPhoto}");
            setTotalReactionsLabelText(labelTotalLikes, $"Total Likes:{FacadeLogicManager.UserPhotosDetails.TotalLikesPhoto}");
            setMostReactionsPictureBox(labelMostComments, pictureBoxMostComments, FacadeLogicManager.UserPhotosDetails.MostCommentsPhotoUrl, FacadeLogicManager.UserPhotosDetails.MostCommentsPhoto);
            setMostReactionsPictureBox(labelMostLikedPhoto, pictureBoxMostLiked, FacadeLogicManager.UserPhotosDetails.MostLikedPhotoUrl, FacadeLogicManager.UserPhotosDetails.MostLikedPhoto);
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
            string name = FacadeLogicManager.GetBestFriendReactions(i_TotalCount, out i_NumberOfReactions, out i_PictureUrl);

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

        public void LoadFeature()
        {
            if (!isFeatureLoad)
            {
                FacadeLogicManager.LoadUserPhotosDetails();
                isFeatureLoad = true;
            }
            else
            {
                this.Show();
            }
           
            updateAllControls();
        }
    }
}
