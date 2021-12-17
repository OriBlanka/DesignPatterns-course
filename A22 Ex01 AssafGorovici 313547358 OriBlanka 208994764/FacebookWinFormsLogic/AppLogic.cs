﻿using System;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsLogic
{
    public class AppLogic
    {
        private AppLogic()
        {
            
        }

        private static readonly object sr_LockGetContext = new object();
        
        private static AppLogic s_Instance;

        public static AppLogic Instance
        {
            get
            {
                if(s_Instance == null)
                {
                    lock(sr_LockGetContext)
                    {
                        if(s_Instance == null)
                        {
                            s_Instance = new AppLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User LoggedUser { get; set; }
        AppSettings m_AppSettings;
        public LoginResult LoginResult { get; set; }

        public void LoginAndLoadUserInfo(ref AppSettings io_appSetting)
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
                io_appSetting.AccessToken = LoginResult.AccessToken;
            }
        }
    }
}
