using System;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsLogic
{
    public class AppLogic
    {
        public AppLogic()
        {
            
        }

        public User LoggedUser { get; set; }

        public LoginResult LoginResult { get; set; }

        public void LoginAndLoadUserInfo()
        {
            LoginResult = FacebookService.Login("4722021931181899", 
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
                LoggedUser = LoginResult.LoggedInUser;
            }
        }
    }
}
