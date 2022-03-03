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
    public partial class FormSchedulePosts : Form
    {

        private const int k_StartPoint = 0;
        private ScheduledPost m_ScheduledPost { get; set; }

        public FormSchedulePosts(User i_LoggedInUser)
        {
            InitializeComponent();

            m_ScheduledPost = new ScheduledPost(i_LoggedInUser);
            setGroupComboBoxByUser();
        }

        private void setGroupComboBoxByUser()
        {
            foreach (var group in m_ScheduledPost.UserGroups)
            {
                comboBoxGroupToPost.Items.Add(group.Name);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            bool isValidPost = m_ScheduledPost.FuturePostPublication(
                (string)comboBoxGroupToPost.SelectedItem,
                textBoxPost.Text,
                m_ScheduledPost.GetPostName(textBoxPostName.Text),
                numericUpDownMinute.Text,
                numericUpDownHours.Text);

            if (isValidPost)
            {
                addDatePublishToListBox();
                clearControllers();
            }
        }

        private void addDatePublishToListBox()
        {
            listBoxPostedDone.Items.Clear();
            listBoxFuture.Items.Clear();

            foreach (var postBySchedule in m_ScheduledPost.ScheduledPostsList)
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
    }
}
