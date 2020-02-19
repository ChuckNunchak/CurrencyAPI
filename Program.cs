using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.cbr-xml-daily.ru/daily_json.js";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            Currency currency = JsonConvert.DeserializeObject<Currency>(response);


            Console.WriteLine("{0} - {1}", currency.Valute["AUD"].Name, currency.Valute["AUD"].Value);
            Console.ReadLine();

        }
    }
}
