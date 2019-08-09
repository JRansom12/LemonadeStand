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
        public int lemonsInPitcher;
        public int sugarInPitcher;
        public int iceCubesInCup;
        public int cupsPerPitcher;
        public int totalCupsPurchased;
        public int cupsPurchasedToday;
        public double todayPurchases;
        public double wallet;
        public double lemonadePrice;
        public Store theStore;

        // constructor
        public Stand()
        {
            lemonsInPitcher = 0;
            sugarInPitcher = 0;
            iceCubesInCup = 0;
            cupsPerPitcher = 0;
            lemonadePrice = 0;
            todayPurchases = 0;
            wallet = 20;
            theStore = new Store();
        }

        // member methods
        public void DisplayInventory()
        {
            Console.WriteLine("Cups: " + theStore.cupCounter + "\nLemons: " + theStore.lemonCounter + "\nCups of Sugar: " + theStore.sugarCounter + "\nIce Cubes: " + theStore.iceCounter);
        }
        public void DisplayMoney()
        {
            Console.WriteLine("Money: " + wallet);
        }
        public void MakePitcherRecipe()
        {
            ChooseLemons();
            ChooseSugar();
            ChooseIce();
            ChooseCups();
            Console.WriteLine("Lemons in pitcher: " + lemonsInPitcher + "\nSugar in pitcher: " + sugarInPitcher + "\nIce cubes per cup: " + iceCubesInCup + "\nCups per pitcher: " + cupsPerPitcher);
        }
        public double SetLemonadePrice()
        {
            Console.WriteLine("What price (between .01 and .99) do you want to sell your lemonade for?");
            lemonadePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price per cup of lemonade is " + lemonadePrice);
            return lemonadePrice;
        }
        public int ChooseLemons()
        {
            Console.WriteLine("Make your lemonade recipe!\nHow many lemons?");
            lemonsInPitcher = Convert.ToInt32(Console.ReadLine());
            return lemonsInPitcher;
        }
        public int AddLemons()
        {
            theStore.lemonCounter -= lemonsInPitcher;
            return theStore.lemonCounter;
        }
        public int ChooseSugar()
        {
            Console.WriteLine("How many cups of sugar?");
            sugarInPitcher = Convert.ToInt32(Console.ReadLine());
            return sugarInPitcher;
        }
        public int AddSugar()
        {
            theStore.sugarCounter -= sugarInPitcher;
            return theStore.sugarCounter;
        }
        public int ChooseIce()
        {
            Console.WriteLine("How many ice cubes per cup?");
            iceCubesInCup = int.Parse(Console.ReadLine());
            if (iceCubesInCup < 10)
            {
                return iceCubesInCup;
            }
            else
            {
                Console.WriteLine("Can't fit 10 or more ice cubes in a cup, sorry. Please choose a smaller number.");
                return ChooseIce();
            }
        }
        public int AddIce()
        {
            if (iceCubesInCup < 2)
            {
                theStore.iceCounter -= 8 * iceCubesInCup;
                return theStore.iceCounter;
            }
            else if (iceCubesInCup >= 2 && iceCubesInCup < 4)
            {
                theStore.iceCounter -= 9 * iceCubesInCup;
                return theStore.iceCounter;
            }
            else if (iceCubesInCup >= 4 && iceCubesInCup < 6)
            {
                theStore.iceCounter -= 10 * iceCubesInCup;
                return theStore.iceCounter;
            }
            else if (iceCubesInCup >= 6 && iceCubesInCup < 8)
            {
                theStore.iceCounter -= 11 * iceCubesInCup;
                return theStore.iceCounter;
            }
            else if (iceCubesInCup >= 8 && iceCubesInCup < 10)
            {
                theStore.iceCounter -= 12 * iceCubesInCup;
                return theStore.iceCounter;
            }
            else
            {
                return theStore.iceCounter;
            }
        }
        public int ChooseCups()
            {
            if (iceCubesInCup < 2)
            {
                cupsPerPitcher = 8;
            }
            else if (iceCubesInCup >= 2 && iceCubesInCup < 4)
            {
                cupsPerPitcher = 9;
            }
            else if (iceCubesInCup >= 4 && iceCubesInCup < 6)
            {
                cupsPerPitcher = 10;
            }
            else if (iceCubesInCup >= 6 && iceCubesInCup < 8)
            {
                cupsPerPitcher = 11;
            }
            else if (iceCubesInCup >= 8 && iceCubesInCup < 10)
            {
                cupsPerPitcher = 12;
            }
            return cupsPerPitcher;
        }
        public int AddCups()
        {
            theStore.cupCounter -= cupsPerPitcher;
            return theStore.cupCounter;
        }
        public double PayForLemons()
        {
            if (theStore.lemonsPurchased == 10)
            {
                todayPurchases += .80;
                wallet -= .80;
                return wallet;
            }
            else if (theStore.lemonsPurchased == 30)
            {
                todayPurchases += 2.10;
                wallet -= 2.10;
                return wallet;
            }
            else if (theStore.lemonsPurchased == 75)
            {
                todayPurchases += 4.50;
                wallet -= 4.50;
                return wallet;
            }
            else
            {
                return wallet;
            }
        }
        public double PayForSugar()
        {
            if (theStore.sugarPurchased == 8)
            {
                todayPurchases += .56;
                wallet -= .56;
                return wallet;
            }
            else if(theStore.sugarPurchased == 20)
            {
                todayPurchases += 1.50;
                wallet -= 1.50;
                return wallet;
            }
            else if(theStore.sugarPurchased == 48)
            {
                todayPurchases += 3.20;
                wallet -= 3.20;
                return wallet;
            }
            else
            {
                return wallet;
            }
            
        }
        public double PayForIce()
        {
            if (theStore.icePurchased == 100)
            {
                todayPurchases += .95;
                wallet -= .95;
                return wallet;
            }
            else if(theStore.icePurchased == 250)
            {
                todayPurchases += 2.25;
                wallet -= 2.25;
                return wallet;
            }
            else if(theStore.icePurchased == 500)
            {
                todayPurchases += 3.95;
                wallet -= 3.95;
                return wallet;
            }
            else
            {
                return wallet;
            }
        }
        public double PayForCups()
        {
            if (theStore.cupsPurchased == 25)
            {
                todayPurchases += .90;
                wallet -= .90;
                return wallet;
            }
            else if(theStore.cupsPurchased == 50)
            {
                todayPurchases += 1.60;
                wallet -= 1.60;
                return wallet;
            }
            else if(theStore.cupsPurchased == 100)
            {
                todayPurchases += 2.80;
                wallet -= 2.80;
                return wallet;
            }
            else
            {
                return wallet;
            }
        }
        public void MakePurchases()
        {
            Console.WriteLine("Which item would you like to purchase? 'cups', 'lemons', 'sugar', 'ice', or 'none'");
            string item = Console.ReadLine();
            switch (item)
            {
                case "cups":
                    theStore.PurchaseCups();
                    PayForCups();
                    DisplayInventory();
                    DisplayMoney();
                    MakePurchases();
                    break;
                case "lemons":
                    theStore.PurchaseLemons();
                    PayForLemons();
                    DisplayInventory();
                    DisplayMoney();
                    MakePurchases();
                    break;
                case "sugar":
                    theStore.GetSugar();
                    PayForSugar();
                    DisplayInventory();
                    DisplayMoney();
                    MakePurchases();
                    break;
                case "ice":
                    theStore.PurchaseIce();
                    PayForIce();
                    DisplayInventory();
                    DisplayMoney();
                    MakePurchases();
                    break;
                case "none":
                    break;
                default:
                    MakePurchases();
                    break;
            }
        }
        public void MakePitcher()
        {
            AddLemons();
            AddSugar();
            AddIce();
        }

        public void EndOfDaySupplies()
        {
            Console.WriteLine("Your remaining ice has melted.");
            theStore.iceCounter = 0;
            DisplayInventory();
            DisplayMoney();
        }
    }
}
