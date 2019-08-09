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
        public List<string> customerList;
        public Stand lemonadeStand;

        // constructor
        public Day()
        {
            weather = new Weather();
            lemonadeStand = new Stand();
            customerList = new List<string>();
            customerList.Add("Customer1");
            customerList.Add("Customer2");
            customerList.Add("Customer3");
            customerList.Add("Customer4");
            customerList.Add("Customer5");
            customerList.Add("Customer6");
            customerList.Add("Customer7");
            customerList.Add("Customer8");
            customerList.Add("Customer9");
            customerList.Add("Customer10");
        }

        // member methods

            public string GetWeather()
        {
            return weather.GetWeather();
        }
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
