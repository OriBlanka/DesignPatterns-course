using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;

namespace FacebookWinFormsLogic
{
    public class FacebookConnector
    {
        public static IFacebookUser Connect(string i_Token, string i_AppId, ref bool io_IsLoggedIn)
        {
            LoginResult loginResult;
            if(string.IsNullOrEmpty(i_Token)) //The user didn't click on the remember me checkBox
            {
                loginResult = FacebookService.Login(i_AppId,
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

                if (!string.IsNullOrEmpty(loginResult.AccessToken))
                {
                    AppLogic.Instance.AccessToken = loginResult.AccessToken;
                    io_IsLoggedIn = true;
                }
                else
                {
                    throw new Exception();
                }
            }
            else //The user clicked on the remember me checkBox so we have his Token
            {
                loginResult = FacebookService.Connect(i_Token);
                io_IsLoggedIn = true;
            }
            
            return new FacebookUserProxy(loginResult.LoggedInUser);
        }
    }
}
