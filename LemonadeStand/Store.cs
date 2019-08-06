using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        // member variables
        public List<string> standInventory;
        public int cupPrice;
        public int lemonPrice;
        public int sugarPrice;
        public int icePrice;
        public int moneySpent;
        public int cupsPurchased;
        public int lemonsPurchased;
        public int sugarPurchased;
        public int icePurchased;
        public Player player1;

        // constructor
        public Store()
        {
            player1 = new Player();
        }

        
        // member methods
        public double PurchaseCups()
        {
            Console.WriteLine("Purchase cups\n25 cups = .90\n50 cups = 1.60\n100 cups = 2.80\nEnter 25, 50, 100, or 0");
            cupsPurchased = Convert.ToInt32(Console.ReadLine());
            if (cupsPurchased == 25)
            {
                player1.cupCounter = player1.cupCounter + 25;
                player1.money = player1.money - .90;
                return player1.money, player1.cupCounter;
            }
        }
    }
}
