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
        public List<Customer> customerList;

        // constructor
        public Day()
        {
            weather = new Weather();
            customerList = new List<Customer>();
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
