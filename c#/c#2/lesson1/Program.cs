using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace lesson1
{
    class Program
    {
        const string _key = "trnsl.1.1.20180316T142736Z.70044299bba0ce3b.01778bbb56d09a0d753dc13da05fc453da19e2c7";
        const string lang = "ru";



        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the english word");
            string text = Console.ReadLine();
            var requestString =
                String.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}&format={3}",
                _key, text, lang, "plain");
 
            var request = WebRequest.Create(requestString);
            request.ContentType = "application/json; charset=utf-8";
            // if ((requestString.Length > 10240) && (request.Method.StartsWith("GET")))
            //     throw new ArgumentException("Text is too long (>10Kb)");
            var response = request.GetResponse();
            var sr = new StreamReader(response.GetResponseStream());
            var json = sr.ReadToEnd();
  
            // System.Console.WriteLine(json);
            
            Dictionary<string, object> dictObj = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            if (dictObj["text"] is JArray)
            {
                System.Console.WriteLine(((JArray)dictObj["text"])[0]);

            }
        }

    }
    public class RootObject
{
    public int code { get; set; }
    public string lang { get; set; }
    public List<string> text { get; set; }
}
}
