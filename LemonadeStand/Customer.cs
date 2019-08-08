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
        public string name;
        public int chanceOfPurchase;
        public bool makesPurchase;

        // constructor
        public Customer(string name, int chanceOfPurchase, bool makesPurchase)
        {
            this.name = name;
            this.chanceOfPurchase = chanceOfPurchase;
            this.makesPurchase = makesPurchase;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ChanceOfPurchase
        {
            get { return chanceOfPurchase; }
            set { chanceOfPurchase = value; }
        }
        public bool MakesPurchase
        {
            get { return makesPurchase; }
            set { makesPurchase = value; }
        }

        // member methods

        public int GenerateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
