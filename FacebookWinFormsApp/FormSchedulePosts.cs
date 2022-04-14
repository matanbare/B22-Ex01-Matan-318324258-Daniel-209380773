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
    public partial class FormSchedulePosts : Form , IScreen
    {
        private const int k_StartPoint = 0;

        private ScheduledPost ScheduledPost { get; set; }

        public FormSchedulePosts()
        {
            InitializeComponent();
        }

        private void setGroupComboBoxByUser()
        {
            foreach (Group group in ScheduledPost.UserGroups)
            {
                comboBoxGroupToPost.Items.Add(group.Name);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (comboBoxGroupToPost.SelectedIndex != 0)
            {
                bool isValidPost = ScheduledPost.FuturePostPublication(
                    (string)comboBoxGroupToPost.SelectedItem,
                    textBoxPost.Text,
                    ScheduledPost.GetPostName(textBoxPostName.Text),
                    numericUpDownMinute.Text,
                    numericUpDownHours.Text);

                if (isValidPost)
                {
                    addDatePublishToListBox();
                    clearControllers();
                }
            }
            else
            {
                MessageBox.Show("You haven't selected any group, please try again...");
            }
        }

        private void addDatePublishToListBox()
        {
            listBoxPostedDone.Items.Clear();
            listBoxFuture.Items.Clear();

            foreach (PostBySchedule postBySchedule in ScheduledPost.ScheduledPostsList)
            {
                if (postBySchedule.IsPosted)
                {
                    listBoxPostedDone.Items.Add($"{postBySchedule.PostID} -> published at {postBySchedule.PublishDate} ");
                }
                else
                {
                    listBoxFuture.Items.Add($"{postBySchedule.PostID} -> will publish at {postBySchedule.PublishDate} ");
                }
            }
        }

        private void clearControllers()
        {
            textBoxPost.Clear();
            textBoxPostName.Clear();
            numericUpDownHours.Value = k_StartPoint;
            numericUpDownMinute.Value = k_StartPoint; 
            comboBoxGroupToPost.SelectedIndex = k_StartPoint;
        }

        private void buttonRefreshPosts_Click(object sender, EventArgs e)
        {
            addDatePublishToListBox();
        }

        private void formSchedulePosts_Load(object sender, EventArgs e)
        {
            comboBoxGroupToPost.SelectedIndex = k_StartPoint;
        }

        public void StartFeature(User i_LoggedInUser)
        {
            ScheduledPost = new ScheduledPost(i_LoggedInUser);
            setGroupComboBoxByUser();
        }
    }
}
