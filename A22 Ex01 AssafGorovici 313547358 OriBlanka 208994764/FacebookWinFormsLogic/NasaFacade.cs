using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookWinFormsLogic
{
    public class NasaFacade
    {
        private readonly NasaApi r_NasaAPI = new NasaApi();
        public string GetNasaPicOfTheDay()
        {
            string pictureURL = r_NasaAPI.GetNasaPictureByDate("");
            return pictureURL;
        }

        public string GetNasaPicBYDate(string i_Date)
        {
            string pictureURL = r_NasaAPI.GetNasaPictureByDate(i_Date);
            return pictureURL;
        }
    }
}
