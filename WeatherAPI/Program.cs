using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json.Linq;


namespace WeatherAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your ZIP code.");
            var zipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode},us&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)}");
            
        }
    }
}
