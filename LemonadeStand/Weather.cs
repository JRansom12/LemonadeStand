using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        // member variables
        public int temperature;
        public int lowTemp;
        public int highTemp;
        public string forecast;
        public string weather;
        public string weatherman;
        public List<string> forecastList;

        // constructor
        public Weather()
        {
            forecastList = new List<string>() { "sunny", "rainy", "cloudy", "hazy" };
            lowTemp = 50;
            highTemp = 100;
        }

        // member methods
        public string GetForecast()
        {
            forecast = forecastList[GenerateNumber(0, forecastList.Count)];
            return forecast;
        }
        public int GetTemp()
        {
            temperature = GenerateNumber(lowTemp, highTemp);
            return temperature;
        }
        public string GetWeather()
        {
            weather = GetTemp() + " degrees and " + GetForecast();
            return weather;
        }
        public string GetWeatherman()
        {
            weatherman = GenerateNumber(temperature - 5, temperature + 5) + " degrees and " + GetForecast();
            return weatherman;
        }
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
