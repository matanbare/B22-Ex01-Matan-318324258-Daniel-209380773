using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class Feature1 : Form
    {
        public Feature1()
        {
            InitializeComponent();
        }

        private void buttonFetchPhotosLikes_Click(object sender, EventArgs e)
        {
            //labelTotalLikes.Text = string.Format("Total Likes: {0}", totalLikesPhoto);
            //labelTotalComments.Text = string.Format("Total Comments: {0}", totalCommentsPhoto);

            //pictureBoxMostComments.LoadAsync(mostCommentsPhotoUrl);
            //pictureBoxMostComments.Enabled = true;

            //pictureBoxMostLiked.LoadAsync(mostLikedPhotoUrl);
            //pictureBoxMostLiked.Enabled = true;

            int mostLikedPhoto = int.MinValue;
            int mostCommentsPhoto = int.MinValue;
            string mostCommentsPhotoUrl = null;
            string mostLikedPhotoUrl = null;

            int totalCommentsPhoto = 0;
            int totalLikesPhoto = 0;


            //foreach (var album in LoggedInUser.Albums)
            //{
            //    foreach (var photo in album.Photos)
            //    {
            //        totalCommentsPhoto += photo.Comments.Count;
            //        totalLikesPhoto += photo.LikedBy.Count;

            //        if (mostLikedPhoto < photo.LikedBy.Count)
            //        {
            //            mostLikedPhoto = photo.LikedBy.Count;
            //            mostLikedPhotoUrl = photo.PictureAlbumURL;
            //        }

            //        if (mostCommentsPhoto < photo.Comments.Count)
            //        {
            //            mostCommentsPhoto = photo.Comments.Count;
            //            mostCommentsPhotoUrl = photo.PictureAlbumURL;
            //        }
            //    }

            //}
        }
    }
}
