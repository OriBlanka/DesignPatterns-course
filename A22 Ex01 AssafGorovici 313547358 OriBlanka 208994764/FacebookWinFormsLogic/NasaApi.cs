using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Text.Json;

namespace FacebookWinFormsLogic
{
    internal class NasaApi
    {
        private const string k_ApiKey = "i6RsCaoahoOhjhcMaexa7wdSjyzwsDoL7Mzrhb7D";
        private const string k_RequestBaseUri = "https://api.nasa.gov/planetary/apod?api_key=";
        
        public string GetNasaPictureByDate(string i_Date)
        {
            String urlWithDate = String.Format("{0}{1}&date={2}", k_RequestBaseUri, k_ApiKey, i_Date);
            var url = urlWithDate;

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }
    }
}

