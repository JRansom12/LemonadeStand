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
        public List<string> inventory;
        public Inventory()
            {
                inventory = new List<string>();
                inventory.Add("cups");
                inventory.Add("lemons");
                inventory.Add("sugar");
                inventory.Add("ice");
            }
    }
}
