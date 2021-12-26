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
        private const string k_ApiKey = "371d19e25cmsh2efefec9d8503bcp1c6603jsn55c3cb22f273";
        private const string k_RequestBaseUri = "https://celebrity-bucks.p.rapidapi.com/birthdays/XML";
        private const string k_ApiHost = "celebrity-bucks.p.rapidapi.com";
        private static readonly HttpClient sr_HttpClient = new HttpClient();
        
        public async Task<XDocument> ApiTest()
        {
           
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{k_RequestBaseUri}"),
                Headers =
                    {
                        { "x-rapidapi-host", $"{k_ApiHost}" },
                        { "x-rapidapi-key", $"{k_ApiKey}" },
                    }
            };
            using(HttpResponseMessage response = await sr_HttpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                return XDocument.Parse(body);
            }

        }

        // Todo Get function to parse document
<<<<<<< HEAD
        public List<string> FilterCelebrityName(XDocument i_XDocument, int i_UserBirthMonth)
=======
        //Todo - Filter the Celebrity name by month number
        public List<string> FilterCelebrityName(XDocument i_XDocument)
>>>>>>> f9199d5788325a8a0b9b5cdf1c07b7b4e55a63a9
        {
            List<string> celebrityNames = new List<string>();
            foreach (XElement element in i_XDocument.Descendants().Where(i_XElement => i_XElement.HasElements == false))
            {
<<<<<<< HEAD
                string keyName = element.Name.LocalName;
                
                XAttribute att = element.Attribute("dob");
                string dobMonth = "-" + i_UserBirthMonth + "-";
                Console.WriteLine(dobMonth);
                if (keyName == "dob")
                {
                    
                    Console.WriteLine(element.Value);
                }    
                //string keyDob = element.Name.LocalName; //?
                /*if (keyDob == "dob")
                {
                    string[] dateOfBirth = element.Value.Split('-');*/
                    //int celebBirthMonth = (int) dateOfBirth[1]; //can't convert string to int
=======
                string keyName = element.Name.LocalName; 
                //string keyDob = element.Name.LocalName; 
                //if (keyDob == "dob")
                //{
                    //string[] dateOfBirth = element.Value.Split('-');
                    //int celebBirthMonth = int.Parse(dateOfBirth[1]); 
>>>>>>> f9199d5788325a8a0b9b5cdf1c07b7b4e55a63a9
                    if(keyName == "name")
                    {
                        celebrityNames.Add(element.Value);
                    }
                //}
                
            }

            return celebrityNames;
        }


    }
}


