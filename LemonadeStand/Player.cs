using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        // member variables
        public Stand lemonadeStand;
        public string name;
        public double money;
        public double cupCounter;
        public int lemonCounter;
        public int sugarCounter;
        public int iceCounter;


        // constructor
        public Player()
        {
            cupCounter = 0;
            lemonCounter = 0;
            sugarCounter = 0;
            iceCounter = 0;
            money = 20;
        }

        // member methods

    }
}
