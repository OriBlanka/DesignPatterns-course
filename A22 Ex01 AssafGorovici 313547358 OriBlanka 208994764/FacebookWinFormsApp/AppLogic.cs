using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class AppLogic
    {
        public AppLogic()
        {
            
        }

        public User LoggedInUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public void LoginAndLoadUserInfo()
        {
            LoginResult = FacebookService.Login("4722021931181899", /// (desig patter's "Design Patterns Course App 2.4" app)
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
                    "user_videos");

            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
        }
    }
}
