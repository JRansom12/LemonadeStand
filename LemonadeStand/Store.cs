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
        public Player player;

        // constructor
        public Store()
        {
            player = new Player();
        }


        // member methods
        public double PurchaseCups(double money)
        {
            Console.WriteLine("Purchase cups\n25 cups = .90\n50 cups = 1.60\n100 cups = 2.80\nEnter 25, 50, 100, or 0");
            cupsPurchased = Convert.ToInt32(Console.ReadLine());
            if (cupsPurchased == 25)
            {
                player.cupCounter += 25;
                money -= .90;
                return money;
                return player.cupCounter;
            }
            else if (cupsPurchased == 50)
            {
                money -= 1.60;
                player.cupCounter += 50;
                return money;
                return player.cupCounter;
            }
            else if (cupsPurchased == 100)
            {
                money -= 2.80;
                player.cupCounter += 100;
                return money;
                return player.cupCounter;
            }
            else
            {
                return money;
                return player.cupCounter;
            }
        }
        public double PurchaseLemons(double money)
        {
            Console.WriteLine("Purchase lemons\n10 lemons = $.80\n30 lemons = $2.10\n75 lemons = $4.50\nEnter 10, 30, 75, or 0");
            if (lemonsPurchased == 10)
            {
                player.lemonCounter += 10;
                money -= .80;
                return money;
                return player.lemonCounter;
            }
            else if (lemonsPurchased == 30)
            {
                money -= 2.10;
                player.lemonCounter += 30;
                return money;
                return player.lemonCounter;
            }
            else if (lemonsPurchased == 75)
            {
                money -= 4.50;
                player.lemonCounter += 75;
                return money;
                return player.lemonCounter;
            }
            else
            {
                return money;
                return player.lemonCounter;
            }
        }
        public double PurchaseSugar(double money)
        {
            Console.WriteLine("Purchase sugar\n8 cups of sugar = $.56\n20 cups of sugar = $1.50\n48 cups of sugar = $3.20\nEnter 8, 20, 48, or 0");
            if (sugarPurchased == 8)
            {
                player.sugarCounter += 8;
                money -= .56;
                return money;
                return player.sugarCounter;
            }
            else if (sugarPurchased == 20)
            {
                money -= 1.50;
                player.sugarCounter += 20;
                return money;
                return player.sugarCounter;
            }
            else if (lemonsPurchased == 48)
            {
                money -= 3.20;
                player.sugarCounter += 48;
                return money;
                return player.sugarCounter;
            }
            else
            {
                return money;
                return player.sugarCounter;
            }
        }
        public double PurchaseIce(double money)
        {
            Console.WriteLine("Purchase ice\n100 ice cubes = $.95\n250 ice cubes = $2.25\n500 ice cubes = $3.95\nEnter 100, 250, 500, or 0");
            if (icePurchased == 100)
            {
                player.iceCounter += 100;
                money -= .95;
                return money;
                return player.iceCounter;
            }
            else if (lemonsPurchased == 250)
            {
                money -= 2.25;
                player.iceCounter += 250;
                return money;
                return player.iceCounter;
            }
            else if (lemonsPurchased == 500)
            {
                money -= 3.95;
                player.iceCounter += 500;
                return money;
                return player.iceCounter;
            }
            else
            {
                return money;
                return player.iceCounter;
            }
        }
    }
}
