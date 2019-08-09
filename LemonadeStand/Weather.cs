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
        public string forecast;
        public string weather;
        public List<string> forecastList;

        // constructor
        public Weather()
        {
            forecastList = new List<string>() { "sunny", "rainy", "cloudy", "hazy" };
        }

        // member methods
        public string GetForecast()
        {
            forecast = forecastList[GenerateNumber(0, 3)];
            return forecast;
        }
        public int GetTemp()
        {
            temperature = GenerateNumber(50, 100);
            return temperature;
        }
        public string GetWeather()
        {
            weather = GetTemp() + " degrees and " + GetForecast();
            return weather;
        }
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
