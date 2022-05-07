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

        private FacadeLogicManager FacadeLogicManager { get; }

        public FormSchedulePosts(FacadeLogicManager iFacadeLogicManager)
        {
            InitializeComponent();

            FacadeLogicManager = iFacadeLogicManager;
        }

        //private void setGroupComboBoxByUser()
        //{
        //    foreach (Group group in FacadeLogicManager.GetUserGroups())
        //    {
        //        comboBoxGroupToPost.Items.Add(group.Name);
        //    }
        //}

        private void setGroupComboBoxByUser()
        {
            foreach (Group group in FacadeLogicManager.GetGroups())
            {
                comboBoxGroupToPost.Items.Add(group);
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {

            string groupName = comboBoxGroupToPost.SelectedItem.ToString();

            if (comboBoxGroupToPost.SelectedIndex != 0)
            {
                bool isValidPost = FacadeLogicManager.LoadSchedulePost (

                    //(string)comboBoxGroupToPost.SelectedItem,
                    groupName,
                    textBoxPost.Text,
                    FacadeLogicManager.GetPostName(textBoxPostName.Text),
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

            foreach (PostBySchedule postBySchedule in FacadeLogicManager.GetPostList())
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

        public void LoadFeature()
        {
            setGroupComboBoxByUser();
        }
    }
}
