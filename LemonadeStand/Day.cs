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
        List<Customer> customerList = new List<Customer>();
        public Day today;
        public int purchaseNumber;
        public double moneyMade;
        public Stand lemonadeStand;

        // constructor
        public Day()
        {
            lemonadeStand = new Stand();
            purchaseNumber = 0;
            today = new Day();
            weather = new Weather();
            customerList.Add(new Customer("customer1", 100, true));
            customerList.Add(new Customer("customer2",75, true));
            customerList.Add(new Customer("customer3",100, true));
            customerList.Add(new Customer("customer4", 50, true));
            customerList.Add(new Customer("customer5", 100, true));
            customerList.Add(new Customer("customer6", 75, true));
            customerList.Add(new Customer("customer7", 100, true));
            customerList.Add(new Customer("customer8", 75, true));
            customerList.Add(new Customer("customer9", 75, true));
            customerList.Add(new Customer("customer10", 100, true));
        }


        // member methods
        public int PurchaseLemonade()
        {
            if (GenerateNumber(50, 100) > weather.temperature)
            {
                 return purchaseNumber++;
            }
            else
            {
                return purchaseNumber;
            }
        }
        public int CustomersPurchase()
        {
            customerList.ForEach(chanceOfPurchase => chanceOfPurchase.PurchaseLemonade());
            return purchaseNumber;
        }
        public double MoneyMade()
        {
            moneyMade = purchaseNumber * lemonadeStand.lemonadePrice;
            return moneyMade;
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
