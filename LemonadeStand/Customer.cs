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
        public int chanceOfPurchase;
        public bool makesPurchase;

        // constructor


        // member methods
        public abstract void PurchaseLemonade();
        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
