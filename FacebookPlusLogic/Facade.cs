using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class Facade
    {
        public ScheduledPost SchedulePost { get; }
        public UserPhotosDetails UserPhotosDetails { get; }

        public Facade(User i_LoggedInUser)
        {
            SchedulePost = new ScheduledPost(i_LoggedInUser);
            UserPhotosDetails = new UserPhotosDetails(i_LoggedInUser.Albums, i_LoggedInUser.Friends);
        }

        public void LoadSchedulePostDetails()
        {
            
        }
    }
}
