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
        public List<string> inventory;
        //public int cupPrice;
        //public int lemonPrice;
        //public int sugarPrice;
        //public int icePrice;
        public int cupsPurchased;
        public int lemonsPurchased;
        public int sugarPurchased;
        public int icePurchased;
        public Player player1;
        public Stand lemonadeStand;

        // constructor
        public Store()
        {
            player1 = new Player();
            lemonadeStand = new Stand();
        }


        // member methods
        public double PurchaseCups()
        {
            Console.WriteLine("Purchase cups\n25 cups = .90\n50 cups = 1.60\n100 cups = 2.80\nEnter 25, 50, 100, or 0");
            cupsPurchased = Convert.ToInt32(Console.ReadLine());
            if (cupsPurchased == 25)
            {
                lemonadeStand.cupCounter += 25;
                player1.money -= .90;
                //return player1.money;
                return lemonadeStand.cupCounter;
            }
            else if (cupsPurchased == 50)
            {
                player1.money -= 1.60;
                lemonadeStand.cupCounter += 50;
                //return player1.money;
                return lemonadeStand.cupCounter;
            }
            else if (cupsPurchased == 100)
            {
                player1.money -= 2.80;
                lemonadeStand.cupCounter += 100;
                //return player1.money;
                return lemonadeStand.cupCounter;
            }
            else
            {
                //return player1.money;
                return lemonadeStand.cupCounter;
            }
        }
        public double PurchaseLemons()
        {
            Console.WriteLine("Purchase lemons\n10 lemons = $.80\n30 lemons = $2.10\n75 lemons = $4.50\nEnter 10, 30, 75, or 0");
            lemonsPurchased = Convert.ToInt32(Console.ReadLine());
            if (lemonsPurchased == 10)
            {
                lemonadeStand.lemonCounter += 10;
                player1.money -= .80;
                //return player1.money;
                return lemonadeStand.lemonCounter;
            }
            else if (lemonsPurchased == 30)
            {
                player1.money -= 2.10;
                lemonadeStand.lemonCounter += 30;
                //return player1.money;
                return lemonadeStand.lemonCounter;
            }
            else if (lemonsPurchased == 75)
            {
                player1.money -= 4.50;
                lemonadeStand.lemonCounter += 75;
                //return player1.money;
                return lemonadeStand.lemonCounter;
            }
            else
            {
                //return player1.money;
                return lemonadeStand.lemonCounter;
            }
        }
        public double PurchaseSugar()
        {
            Console.WriteLine("Purchase sugar\n8 cups of sugar = $.56\n20 cups of sugar = $1.50\n48 cups of sugar = $3.20\nEnter 8, 20, 48, or 0");
            sugarPurchased = Convert.ToInt32(Console.ReadLine());
            if (sugarPurchased == 8)
            {
                lemonadeStand.sugarCounter += 8;
                player1.money -= .56;
                return lemonadeStand.sugarCounter;
                //return player1.money;
            }
            else if (sugarPurchased == 20)
            {
                player1.money -= 1.50;
                lemonadeStand.sugarCounter += 20;
                //return player1.money;
                return lemonadeStand.sugarCounter;
            }
            else if (lemonsPurchased == 48)
            {
                player1.money -= 3.20;
                lemonadeStand.sugarCounter += 48;
                //return player1.money;
                return lemonadeStand.sugarCounter;
            }
            else
            {
                //return player1.money;
                return lemonadeStand.sugarCounter;
            }
        }
        public double PurchaseIce()
        {
            Console.WriteLine("Purchase ice\n100 ice cubes = $.95\n250 ice cubes = $2.25\n500 ice cubes = $3.95\nEnter 100, 250, 500, or 0");
            icePurchased = Convert.ToInt32(Console.ReadLine());
            if (icePurchased == 100)
            {
                lemonadeStand.iceCounter += 100;
                player1.money -= .95;
                //return player1.money;
                return lemonadeStand.iceCounter;
            }
            else if (lemonsPurchased == 250)
            {
                player1.money -= 2.25;
                lemonadeStand.iceCounter += 250;
                //return player1.money;
                return lemonadeStand.iceCounter;
            }
            else if (lemonsPurchased == 500)
            {
                player1.money -= 3.95;
                lemonadeStand.iceCounter += 500;
                //return player1.money;
                return lemonadeStand.iceCounter;
            }
            else
            {
                //return player1.money;
                return lemonadeStand.iceCounter;
            }
        }
    }
}
