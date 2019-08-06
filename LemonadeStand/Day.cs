using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        // member variables
        public Weather weather;

        // constructor
        public Day()
        {
            weather = new Weather();
        }

        // member methods
        public string GetDayWeather()
        {
            return weather.GetWeather();
        }
    }
}
