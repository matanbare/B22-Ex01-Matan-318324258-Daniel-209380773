using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookAdapter : FacebookService, ILoginable
    {
        public User LoggedInUser { get; set; }

        private LoginResult LoginResult { get; set; }

        public void Login()
        {
            try
            {
                LoginResult = FacebookService.Login(
                    "484536506563845",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "groups_access_member_info",
                    "publish_to_groups");
            }
            catch (Exception)
            {
                throw new Exception("Login Is Failed, Please Try Again");
            }

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
                ApplicationSettings.Instance.AccessToken = LoginResult.AccessToken;
            }
            else
            {
                throw new Exception("Login Is Failed, Please Try Again");
            }
        }

        public void AutoLogin()
        {
            LoginResult = FacebookService.Connect(ApplicationSettings.Instance.AccessToken);
            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
        }
    }
}