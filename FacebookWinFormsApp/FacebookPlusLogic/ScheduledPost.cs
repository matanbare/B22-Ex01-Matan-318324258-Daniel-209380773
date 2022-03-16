using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class ScheduledPost
    {
        private const int k_HourToMillisecond = 3600000;
        private const int k_MinuteToMillisecond = 60000;
        private const string k_Unknown = "*UNKNOWN*";
        private const string k_EmptyText = "";
        private static int s_CounterTimers = 0;

        public List<PostBySchedule> ScheduledPostsList { get; } = new List<PostBySchedule>();

        public FacebookObjectCollection<Group> UserGroups { get; set; }

        public ScheduledPost(User i_LoggedInUser)
        {
            UserGroups = i_LoggedInUser.Groups;
        }

        public bool FuturePostPublication(string i_GroupName, string i_TextToPost, string i_PostID, string i_Minute, string i_Hours)
        {
            bool isValidTextToPost = false;

            PostBySchedule newPostToPublish = new PostBySchedule()
            {
                TimeToPostInMillisecond = ConvertToMillisecond(i_Minute, i_Hours),
                PublishDate = GetFutureDateToPublish(i_Minute, i_Hours),
                PostText = i_TextToPost,
                PostID = i_PostID,
                GroupName = i_GroupName
            };

            if (textIsNotEmpty(i_TextToPost))
            {
                isValidTextToPost = true;
                newPostToPublish.TimerToPost.Tick += timerToPost_Tick;
                newPostToPublish.TimerToPost.Interval = 
                    newPostToPublish.TimeToPostInMillisecond > 0 ? newPostToPublish.TimeToPostInMillisecond : 1000;
                newPostToPublish.TimerToPost.Enabled = true;
                newPostToPublish.TimerToPost.Tag = s_CounterTimers++;
                ScheduledPostsList.Add(newPostToPublish);
            }
            else
            {
                string messageForUser = $" The text field is empty! Please try again. ";
                MessageBox.Show(messageForUser);
            }

            return isValidTextToPost;
        }

        private void postNow(string i_GroupName, string i_TextToPost)
        {
            string messageForUser = null;

            foreach (Group group in UserGroups)
            {
                if (group.Name == i_GroupName)
                {
                    try
                    {
                        group.PostToWall(i_TextToPost);
                        messageForUser = $" ***Publish Succeeded*** ";
                    }
                    catch (FacebookApiException)
                    {
                        messageForUser = $"Error => Something went wrong please try again";
                    }
                }
            }

            MessageBox.Show(messageForUser);
        }

        private void timerToPost_Tick(object sender, EventArgs e)
        {
            int index = (int)(sender as Timer).Tag;

            (sender as Timer).Enabled = false;
            postNow(ScheduledPostsList[index].GroupName, ScheduledPostsList[index].PostText);
            ScheduledPostsList[index].IsPosted = true;
        }

        public int ConvertToMillisecond(string i_Minute, string i_Hours)
        {
            return (k_HourToMillisecond * int.Parse(i_Hours)) + (k_MinuteToMillisecond * int.Parse(i_Minute));
        }
        
        private bool textIsNotEmpty(string i_TextToPost)
        {
            return i_TextToPost != k_EmptyText;
        }

        public string GetPostName(string i_UserInput)
        {
            return i_UserInput != k_EmptyText ? i_UserInput : k_Unknown;
        }

        public DateTime GetFutureDateToPublish(string i_Minutes, string i_Hours)
        {
            DateTime dateToPublish = DateTime.Now;
            dateToPublish = dateToPublish.AddHours(double.Parse(i_Hours));
            dateToPublish = dateToPublish.AddMinutes(double.Parse(i_Minutes));

            return dateToPublish;
        }
    }
}
