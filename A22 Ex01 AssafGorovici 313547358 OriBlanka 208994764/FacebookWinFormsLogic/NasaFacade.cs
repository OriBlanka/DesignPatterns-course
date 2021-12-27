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
            string response = r_NasaAPI.GetNasaPictureByDate("");
            string pictureUrl = fetchPicUrl(response);
            return pictureUrl;
        }

        public string GetNasaPicBYDate(string i_Date)
        {
            string response = r_NasaAPI.GetNasaPictureByDate(i_Date);
            string pictureUrl = fetchPicUrl(response);
            return pictureUrl;
        }

        private static string fetchPicUrl(string i_Response)
        {
            string[] responseParts = i_Response.Split(',');
            int urlIndex = responseParts.Length - 1;
            responseParts[urlIndex] = responseParts[urlIndex].Substring(7);
            responseParts[urlIndex] = responseParts[urlIndex].Remove(responseParts[urlIndex].Length - 3);
            return responseParts[urlIndex];
        }
    }
}
