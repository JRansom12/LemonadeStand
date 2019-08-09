using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Customer
    {
        // member variables


        // constructor


        // member methods
        public void MakesPurchase()
        {
            totalCupsPurchased++;
            theStore.cupCounter--;
            wallet += lemonadePrice;
            cupsPurchasedToday++;
        }

        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
