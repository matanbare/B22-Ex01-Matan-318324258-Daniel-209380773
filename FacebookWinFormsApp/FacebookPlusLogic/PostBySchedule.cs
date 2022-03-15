using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class PostBySchedule
    {
        public Timer TimerToPost { get; }

        public string PostText { get; set; } 

        public string PostID { get; set; } 

        public string GroupName { get; set; }

        public int TimeToPostInMillisecond { get; set; }

        public DateTime PublishDate { get; set; }

        public bool IsPosted { get; set; } = false;

        public PostBySchedule()
        {
            TimerToPost = new Timer();
        }
    }
}
