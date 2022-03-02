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
    class ScheduledPost
    {
        private const int k_HourToMillisecond = 3600000;
        private const int k_MinuteToMillisecond = 60000;
        private const string k_Unknown = "*UNKNOWN*";
        private const string k_EmptyText = "";
        private static int couterTimers = 0;
        private readonly List<PostBySchedule> m_Timers = new List<PostBySchedule>();
        public FacebookObjectCollection<Group> UserGroups { get; set; }

        public ScheduledPost(User i_LoggedInUser)
        {
            UserGroups = i_LoggedInUser.Groups;
        }

        public void FuturePostPublication(string i_GroupName, string i_TextToPost, string i_PostID, string i_Minute, string i_Hours)
        {
            PostBySchedule newPostToPublish = new PostBySchedule()
            {
                TimeToPostInMillisecond = ConvertToMillisecond(i_Minute, i_Hours),
                PostText = i_TextToPost,
                PostID = i_PostID,
                GroupName = i_GroupName
            };

            newPostToPublish.TimerToPost.Tick += TimerToPost_Tick;
            newPostToPublish.TimerToPost.Interval = newPostToPublish.TimeToPostInMillisecond;
            newPostToPublish.TimerToPost.Enabled = true;
            newPostToPublish.TimerToPost.Tag = couterTimers++;
            m_Timers.Add(newPostToPublish);
        }

        private bool postNow(string i_GroupName, string i_TextToPost)
        {
            bool isValidMessage = false;
            
            string messageForUser = null;

            if (textIsNotEmpty(i_TextToPost))
            {
                foreach (var group in UserGroups)
                {
                    if (group.Name == i_GroupName)
                    {
                        try
                        {
                            group.PostToWall(i_TextToPost);
                            messageForUser = $" ***Publish Succeeded*** ";
                            isValidMessage = true;
                        }
                        catch (FacebookApiException e)
                        {
                            messageForUser = $" {e.ErrorType} + Error ";
                        }
                    }
                }
            }
            else
            {
                messageForUser = $" The text field is empty! Please try again. ";
            }

            MessageBox.Show(messageForUser);
            return isValidMessage;
        }

        private void TimerToPost_Tick(object sender, EventArgs e)
        {
            int index = (int)(sender as Timer).Tag;

            postNow(m_Timers[index].GroupName, m_Timers[index].PostText);
            (sender as Timer).Enabled = false;
        }



        public int ConvertToMillisecond(string i_Minute, string i_Hours)
        {
            return k_HourToMillisecond * int.Parse(i_Hours) + k_MinuteToMillisecond * int.Parse(i_Minute);
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
