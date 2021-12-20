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

        public string AccessToken { get; set; }

        //Todo - need to remove after making all changes in FormMain class
        public User LoggedUser { get; set; }

        public LoginResult LoginResult { get; set; }

        private IFacebookUser m_FacebookUser;

        public IFacebookUser GetUser()
        {
            return m_FacebookUser;
        }

        public void Connect(string i_AppSettingsLastAccessToken, string i_AppId, ref bool io_IsLoggedIn)
        {
            m_FacebookUser = FacebookConnector.Connect(i_AppSettingsLastAccessToken, i_AppId, ref io_IsLoggedIn);
        }
    }
}
