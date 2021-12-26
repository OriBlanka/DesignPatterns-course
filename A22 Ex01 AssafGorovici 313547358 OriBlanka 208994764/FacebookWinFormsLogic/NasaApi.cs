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
    public class NasaApi
    {
        private const string k_ApiKey = "i6RsCaoahoOhjhcMaexa7wdSjyzwsDoL7Mzrhb7D";
        private const string k_RequestBaseUri = "https://api.nasa.gov/planetary/apod?api_key=i6RsCaoahoOhjhcMaexa7wdSjyzwsDoL7Mzrhb7D";

       // private static readonly HttpClient sr_HttpClient = new HttpClient();

        public string ApiTestNasa()
        {
            var url = "https://api.nasa.gov/planetary/apod?api_key=i6RsCaoahoOhjhcMaexa7wdSjyzwsDoL7Mzrhb7D";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }

            //Console.WriteLine(httpResponse.StatusCode);
            //return httpResponse;
            /*HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{k_RequestBaseUri}"),
                Headers =
                    {
                        { "x-rapidapi-host", $"{k_ApiHost}" },
                        { "x-rapidapi-key", $"{k_ApiKey}" },
                    }
            };
            using (HttpResponseMessage response = await sr_HttpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                return XDocument.Parse(body);
            }*/

        }

        // Todo Get function to parse document



        //Todo - Filter the Celebrity name by month number
        /*public List<string> FilterCelebrityName(XDocument i_XDocument)
        {
            List<string> celebrityNames = new List<string>();
            foreach (XElement element in i_XDocument.Descendants().Where(i_XElement => i_XElement.HasElements == false))
            {

                string keyName = element.Name.LocalName;

                if (keyName == "name")
                {
                    celebrityNames.Add(element.Value);
                }


            }

            return celebrityNames;
        }*/


    }
}

