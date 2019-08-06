using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Stand
    {
        // member variables
        public List<string> standInventory;
        public int price;
        public int expenses;
        public int profit;
        public int cupCounter;
        public int lemonCounter;
        public int sugarCounter;
        public int iceCounter;
        public int pitcher;
        public int cup;
        // constructor
        public Stand()
        {
            cupCounter = 0;
            lemonCounter = 0;
            sugarCounter = 0;
            iceCounter = 0;
        }
        // assign standInventory numbers 0 to start

        // member methods
        public void DisplayInventory()
        {
            Console.WriteLine("Cups: " + cupCounter + "Lemons: " + lemonCounter + "Cups of Sugar: " + sugarCounter + "Ice Cubes: " + iceCounter);
        }
        public void MakePitcher()
        {

        }
    }
}
