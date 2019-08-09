using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Man : Customer
    {
        // member variables

        // constructor

        // member methods
        public void BuysLemonade()
        {
            if (.15 <= lemonadePrice <= .50)
            {
                MakesPurchase();
            }
        }
    }
}
