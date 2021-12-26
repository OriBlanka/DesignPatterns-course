using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace FacebookWinFormsLogic
{
    public class CelebrityBirthdayFacade
    {
        private readonly CelebrityBirthdayAPI r_CelebrityBirthdayAPI = new CelebrityBirthdayAPI();
        public async Task<List<string>> GetCelebrityList(
            IFacebookUser i_LoggedUser)
        {
            
            Dictionary<string, List<string>> celebrityDictionary = new Dictionary<string, List<string>>();
            //List<string> userFavoriteArtists = new List<string>();
            /*if (i_IsMockState)

            {
                userFavoriteArtists = MocksGenerator.GetFakeArtists();
            }
            else
            {
                foreach (Page artistPage in i_LoggedUser.GetLikedPages())
                {
                    if (artistPage.Category == "Artist")
                    {
                        userFavoriteArtists.Add(artistPage.Name);
                    }
                }
            }*/

            /*foreach (string favoriteArtist in userFavoriteArtists)
            {*/
                XDocument celebrityListXML =
                    await r_CelebrityBirthdayAPI.ApiTest();
                List<string> celebrityList = r_CelebrityBirthdayAPI.FilterCelebrityName(celebrityListXML);

            /*celebrityDictionary.Add(favoriteArtist, userSimilarArtistsList);*/
            //}

            return celebrityList;
        }
    }
}
