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
        }

        // member methods
        public List<string> GenerateCustomers()
        {
            if(weather.temperature <= 60)
            {
                customerList = new List<string>(new string[GenerateNumber(50, 60)]);
                return customerList;
            }
            else if (weather.temperature <= 70)
            {
                customerList = new List<string>(new string[GenerateNumber(60, 70)]);
                return customerList;
            }
            else if (weather.temperature <= 80)
            {
                customerList = new List<string>(new string[GenerateNumber(70, 80)]);
                return customerList;
            }
            else if (weather.temperature <= 90)
            {
                customerList = new List<string>(new string[GenerateNumber(80, 90)]);
                return customerList;
            }
            else
            {
                customerList = new List<string>(new string[GenerateNumber(90, 100)]);
                return customerList;
            }
        }
        
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
