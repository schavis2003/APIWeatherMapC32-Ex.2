
using System;
using System.IO;
using Newtonsoft.Json.Linq;  

namespace APIWeatherMapC32_Ex._2;

public class Program
{
    public static void Main(string[] args)
    {
        
        string key = File.ReadAllText("appsettings.json");
        string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

        Console.WriteLine("Please enter you zipcode");

        var zipCode = Console.ReadLine();

        var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
        Console.WriteLine();

        Console.WriteLine($"It is currently  {WeatherMap.GetTemp(apiCall)} degrees F in your location.");
    }
}
