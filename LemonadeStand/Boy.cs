using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Boy : Customer
    {
        // member variables

        // constructor
        public Boy()
        {
        }

        // member methods
        public void BuyLemonade()
        {
            if (lemonsInPitcher <= sugarInPitcher && 2 <= iceCubesInCup <= 6 && .15 <= lemonadePrice <= .30)
            {
                MakesPurchase();
            }
        }
    }
}
