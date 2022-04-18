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
        public static IScreen CreateScreen(eScreenType iEScreenType, FacadeLogicManager i_FacadeLogicManager)
        {
            IScreen screen = null;

            switch (iEScreenType)
            {
                case eScreenType.SchedulePost:
                    screen = new FormSchedulePosts(i_FacadeLogicManager);
                    break;
                case eScreenType.PhotoDetails:
                    screen = new FormPhotosDetails(i_FacadeLogicManager);
                    break;
            }

            return screen;
        }
    }
}
