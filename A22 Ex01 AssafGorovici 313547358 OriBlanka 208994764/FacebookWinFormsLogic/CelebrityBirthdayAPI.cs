using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Xml.Linq;

namespace FacebookWinFormsLogic
{
    // Todo check if api works
    internal class CelebrityBirthdayAPI
    {

        /*private static readonly HttpClient sr_HttpClient = new HttpClient();
        HttpRequestMessage request = new HttpRequestMessage*/
        public async Task<XDocument> ApiTest()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://celebrity-bucks.p.rapidapi.com/birthdays/XML"),
                Headers =
    {
        { "x-rapidapi-host", "celebrity-bucks.p.rapidapi.com" },
        { "x-rapidapi-key", "371d19e25cmsh2efefec9d8503bcp1c6603jsn55c3cb22f273" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                return XDocument.Parse(body);
            }
            
        }

        // Todo Get function to parse document
        public List<string> FilterCelebrityName(XDocument i_XDocument)
        {
            List<string> celebrityNames = new List<string>();
            foreach (XElement element in i_XDocument.Descendants().Where(i_XElement => i_XElement.HasElements == false))
            {
                string keyName = element.Name.LocalName; //?
                //string keyDob = element.Name.LocalName; //?
                /*if (keyDob == "dob")
                {
                    string[] dateOfBirth = element.Value.Split('-');*/
                    //int celebBirthMonth = (int) dateOfBirth[1]; //can't convert string to int
                    if(keyName == "name")
                    {
                        celebrityNames.Add(element.Value);
                    }
               // }
                
            }

            return celebrityNames;
        }


    }
}


