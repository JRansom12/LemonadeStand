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
        public int forecastTemp;
        public string forecast;
        public string weather;
        public List<string> forecastList;

        // constructor
        public Weather()
        {
            forecastList = new List<string>();
            forecastList.Add("sunny");
            forecastList.Add("rainy");
            forecastList.Add("cloudy");
            forecastList.Add("hazy");
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
        //public int GetForecastTemp()
        //{
        //    GetTemp();
        //    forecastTemp = GenerateNumber(temperature - 5, temperature + 5);
        //    return forecastTemp;
        //}
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
