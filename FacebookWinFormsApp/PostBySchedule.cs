using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    class PostBySchedule
    {
        private const string k_Unknown = "*UNKNOWN*";
        private const string k_EmptyText = "";

        public Timer TimerToPost { get ;}
        public string PostText { get; set; } 
        public string PostID { get; set; } 
        public string GroupName { get; set; }
        public int TimeToPostInMillisecond { get; set; }
        public DateTime PublishDate { get; set; }
        public bool IsPosted { get; set; } = false;

        //int i_MillisecondToPost, string i_PostText, string i_PostID, string i_GroupName
        public PostBySchedule()
        {
            TimerToPost = new Timer();
            //TimeToPostInMillisecond = i_MillisecondToPost;
            //PostText = i_PostText;
            //PostID = i_PostID;
            //GroupName = i_GroupName;

            //TimerToPost.Interval = TimeToPostInMillisecond;
        }
    }
}
