using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        // member variables
        public int chanceBuyLemonade;
        bool willBuyLemonade;
        public List<string> customerList;

        // constructor
        public Customer()
        {
            customerList = new List<string>();
            customerList.Add("customer1");
            customerList.Add("customer2");
            customerList.Add("customer3");
            customerList.Add("customer4");
            customerList.Add("customer5");
            customerList.Add("customer6");
            customerList.Add("customer7");
            customerList.Add("customer8");
            customerList.Add("customer9");
            customerList.Add("customer10");           
        }
        


        // member methods
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void customerBuyLemonade()
        {
            if(GenerateNumber(50,100) < 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
