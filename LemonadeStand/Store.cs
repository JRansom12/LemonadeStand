using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store  //Access Modifiers need to be consistent, private, public, or
    {
        // member variables
        public List<string> inventory;
        public int cupsPurchased;
        public int lemonsPurchased;
        public int sugarPurchased;
        public int icePurchased;
        public int sugarCounter;
        public int lemonCounter;
        public int cupCounter;
        public int iceCounter;
        public double price50Cups = 1.60;
        public double price25Cups = .90;
        public double price100Cups = 2.80;
        public double ice100Cubes = .95;
        public double ice250Cubes = 2.25;
        public double ice500Cubes = 3.95;
        public double sugar8Cups = .56;
        public double sugar20Cups = 1.50;
        public double sugar48Cups = 3.20;

        // constructor


        // member methods

        public int PurchaseCups()
        {
            Console.WriteLine("Purchase cups\n25 cups = .90\n50 cups = 1.60\n100 cups = 2.80\nEnter 25, 50, 100, or 0");
            cupsPurchased = Convert.ToInt32(Console.ReadLine());
            if (cupsPurchased == 25)
                {
                    cupCounter += 25;
                    return cupCounter;
                }
                else if (cupsPurchased == 50)
                {
                    cupCounter += 50;
                    return cupCounter;
                }
                else if (cupsPurchased == 100)
                {
                    cupCounter += 100;
                    return cupCounter;
                }
                else
                {
                    Console.WriteLine("Not a valid number of cups to purchase");
                    return cupCounter;
                }
        }
        public int PurchaseLemons()
        {    
            Console.WriteLine("Purchase lemons\n10 lemons = $.80\n30 lemons = $2.10\n75 lemons = $4.50\nEnter 10, 30, 75, or 0");
            lemonsPurchased = int.Parse(Console.ReadLine());
            if (lemonsPurchased == 10)
            {
                lemonCounter += 10;
                return lemonCounter;
            }
            else if (lemonsPurchased == 30)
            {
                lemonCounter += 30;
                return lemonCounter;
            }
            else if (lemonsPurchased == 75)
            {
                lemonCounter += 75;
                return lemonCounter;
            }
            else
            {
                Console.WriteLine("Not a valid number of lemons to purchase");
                return lemonCounter;
            }
        }
        public int GetSugar()
        {
            Console.WriteLine("Purchase sugar\n8 cups of sugar = $.56\n20 cups of sugar = $1.50\n48 cups of sugar = $3.20\nEnter 8, 20, 48, or 0");
            sugarPurchased = int.Parse(Console.ReadLine());
            if (sugarPurchased == 8)
            {
                sugarCounter += 8;
                return sugarCounter;
            }
            else if (sugarPurchased == 20)
            {
                sugarCounter += 20;
                return sugarCounter;
            }
            else if (sugarPurchased == 48)
            {
                sugarCounter += 48;
                return sugarCounter;
            }
            else
            {
                Console.WriteLine("Not a valid number of cups of sugar to purchase");
                return sugarCounter;
            }
        }
        public int PurchaseIce()
        {
            Console.WriteLine("Purchase ice\n100 ice cubes = $.95\n250 ice cubes = $2.25\n500 ice cubes = $3.95\nEnter 100, 250, 500, or 0");
            string input = Console.ReadLine();
            if (!Int32.TryParse(input, out icePurchased))
            {
                Console.WriteLine("Not a valid number");
                PurchaseIce();
            }
            icePurchased = int.Parse(input);
            if (icePurchased == 100)
            {
                iceCounter += 100;
                return iceCounter;
            }
            else if (icePurchased == 250)
            {
                iceCounter += 250;
                return iceCounter;
            }
            else if (icePurchased == 500)
            {
                iceCounter += 500;
                return iceCounter;
            }
            else
            {
                Console.WriteLine("Not a valid number of ice cubes to purchase");
                return iceCounter;
            }
        }
        public void DisplayInventory()
        {
            Console.WriteLine("Cups: " + cupCounter + "\nLemons: " + lemonCounter + "\nCups of Sugar: " + sugarCounter + "\nIce Cubes: " + iceCounter);
        }
    }
}
