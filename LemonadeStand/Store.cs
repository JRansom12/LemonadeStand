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
        public int cupsPurchased;
        public int lemonsPurchased;
        public int sugarPurchased;
        public int icePurchased;
        public int sugarCounter;
        public int lemonCounter;
        public int cupCounter;
        public int iceCounter;

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
                    return cupCounter;
                }
        }
        public int PurchaseLemons()  //Open Close Principle can be applied here
                                     //Create a PurchaseInventory method that each inventory item can override
                                     //Also a AddSuppliesToInventory and SubtractCostfromWallet, which would allow the inventory to grow or shrink as needed, instead of having to write all new code for each inventory item
        {
            Console.WriteLine("Purchase lemons\n10 lemons = $.80\n30 lemons = $2.10\n75 lemons = $4.50\nEnter 10, 30, 75, or 0");
            lemonsPurchased = int.Parse(Console.ReadLine()); //Code is definitely breakable at submission, important part of developing is making code user friendly and anticipating for any user input
            if (lemonsPurchased == 10)                      //An important part of problem solving is preventing the problem in the first place, and user error, focus on this for resubmission
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
                return sugarCounter;
            }
        }
        public int PurchaseIce()
        {
            Console.WriteLine("Purchase ice\n100 ice cubes = $.95\n250 ice cubes = $2.25\n500 ice cubes = $3.95\nEnter 100, 250, 500, or 0");
            icePurchased = int.Parse(Console.ReadLine());
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
                return iceCounter;
            }
        }
        public void DisplayInventory()
        {
            Console.WriteLine("Cups: " + cupCounter + "\nLemons: " + lemonCounter + "\nCups of Sugar: " + sugarCounter + "\nIce Cubes: " + iceCounter);
        }
    }
}
