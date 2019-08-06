using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables
        public List<string> standInventory;
        public Inventory()
            {
                standInventory = new List<string>();
                standInventory.Add("cups");
                standInventory.Add("lemons");
                standInventory.Add("sugar");
                standInventory.Add("ice");
            }
    }
}
