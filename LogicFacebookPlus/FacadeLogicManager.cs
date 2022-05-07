using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.ENums;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacadeLogicManager
    {
        private ScheduledPost SchedulePost { get; }
        public UserPhotosDetails UserPhotosDetails { get; }

        public FacadeLogicManager(User i_LoggedInUser)
        {
            SchedulePost = new ScheduledPost(i_LoggedInUser);
            UserPhotosDetails = new UserPhotosDetails(i_LoggedInUser.Albums, i_LoggedInUser.Friends);
        }

        public bool LoadSchedulePost(string i_GroupName, string i_TextToPost, string i_PostID, string i_Minute, string i_Hours)
        {
            return SchedulePost.FuturePostPublication(i_GroupName, i_TextToPost, i_PostID, i_Minute, i_Hours);
        }

        public void LoadUserPhotosDetails()
        {
            UserPhotosDetails.TakeAllDetails();
        }

        public FacebookObjectCollection<Group> GetUserGroups()
        {
            return SchedulePost.UserGroups;
        }

        public IEnumerable<Group> GetGroups()
        {
            foreach (Group group in SchedulePost.UserGroups)
            {
                yield return group;
            }
        }

        public string GetPostName(string i_UserInput)
        {
            return SchedulePost.GetPostName(i_UserInput);
        }

        public List<PostBySchedule> GetPostList()
        {
            return SchedulePost.ScheduledPostsList;
        }

        public string GetBestFriendReactions(eTotalCount i_TotalCount, out int i_NumberOfReactions,
            out string i_PictureUrl)
        {
            string friendName =
                UserPhotosDetails.GetBestFriendReactions(i_TotalCount, out i_NumberOfReactions, out i_PictureUrl);

            return friendName;
        }
    }
}
