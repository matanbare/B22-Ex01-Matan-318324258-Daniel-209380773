using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class ScreenFactory
    {
        public static IScreen CreateScreen(eScreen i_EScreen)
        {
            IScreen screen = null;

            switch (i_EScreen)
            {
                case eScreen.SchedulePost:
                    screen = new FormSchedulePosts();
                    break;
                case eScreen.PhotoDetails:
                    screen = new FormPhotosDetails();
                    break;
            }

            return screen;
        }

    }

    public enum eScreen
    {
        PhotoDetails = 1,
        SchedulePost
    }
}
