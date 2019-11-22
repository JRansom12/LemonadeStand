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
        //public List<string> standInventory;
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
            wallet = 4;
            theStore = new Store();
        }

        // member methods

        // Interface Segregation Principle

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
            if(lemonadePrice >= .99 || lemonadePrice <= .01)
            {
                SetLemonadePrice();
            }
            Console.WriteLine("Price per cup of lemonade is " + lemonadePrice);
            return lemonadePrice;
        }
        public int ChooseLemons()
        {
            Console.WriteLine("Make your lemonade recipe!\nHow many lemons?");
            lemonsInPitcher = Convert.ToInt32(Console.ReadLine());
            return lemonsInPitcher;
        }
        public void AddLemons()
        {
            theStore.lemonCounter -= lemonsInPitcher;
            if(theStore.lemonCounter < 0)
            {
                theStore.lemonCounter = 0;
                Console.WriteLine("Not enough lemons to make another pitcher");
                EndOfDaySupplies();
            }
        }
        public int ChooseSugar()
        {                       
            Console.WriteLine("How many cups of sugar?");
            sugarInPitcher = Convert.ToInt32(Console.ReadLine());
            return sugarInPitcher;
        }
        public void AddSugar()
        {
            theStore.sugarCounter -= sugarInPitcher;
            if(theStore.sugarCounter < 0)
            {
                theStore.sugarCounter = 0;
                Console.WriteLine("Not enough sugar to make another pitcher");
                EndOfDaySupplies();
            }
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
        public void AddIce()
        {
            if (iceCubesInCup < 2)
            {
                theStore.iceCounter -= 8 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 2 && iceCubesInCup < 4)
            {
                theStore.iceCounter -= 9 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 4 && iceCubesInCup < 6)
            {
                theStore.iceCounter -= 10 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 6 && iceCubesInCup < 8)
            {
                theStore.iceCounter -= 11 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 8 && iceCubesInCup < 10)
            {
                theStore.iceCounter -= 12 * iceCubesInCup;
            }
            if(theStore.iceCounter < 0)
            {
                theStore.iceCounter = 0;
                Console.WriteLine("Not enough ice to make another picther");
                EndOfDaySupplies();
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
        public void PayForSugar()
        {
            if (theStore.sugarPurchased == 8)
            {
                if (wallet >= theStore.sugar8Cups)
                {
                    todayPurchases += theStore.sugar8Cups;
                    wallet -= theStore.sugar8Cups;
                }
                else
                {
                    theStore.sugarCounter -= 8;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
            else if(theStore.sugarPurchased == 20)
            {
                if (wallet >= theStore.sugar20Cups)
                {
                    todayPurchases += theStore.sugar20Cups;
                    wallet -= theStore.sugar20Cups;
                }
                else
                {
                    theStore.sugarCounter -= 20;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
            else if(theStore.sugarPurchased == 48)
            {
                if(wallet >= theStore.sugar48Cups)
                {
                    todayPurchases += theStore.sugar48Cups;
                    wallet -= theStore.sugar48Cups;
                }
                else
                {
                    theStore.sugarCounter -= 20;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
        }

        public void PayForIce()
        {
            if (theStore.icePurchased == 100)
            {
                if (wallet >= theStore.ice100Cubes)
                {
                    todayPurchases += theStore.ice100Cubes;
                    wallet -= theStore.ice100Cubes;
                }
                else
                {
                    theStore.iceCounter -= 100;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
            else if(theStore.icePurchased == 250)
            {
                if (wallet >= theStore.ice250Cubes)
                {
                    todayPurchases += theStore.ice250Cubes;
                    wallet -= theStore.ice250Cubes;
                }
                else
                {
                    theStore.iceCounter -= 250;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
            else if(theStore.icePurchased == 500)
            {
                if (wallet >= theStore.icePurchased)
                {
                    todayPurchases += theStore.ice500Cubes;
                    wallet -= theStore.ice500Cubes;
                }
                else
                {
                    theStore.iceCounter -= 500;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
        }
        public void PayForCups()
        {
            if (theStore.cupsPurchased == 25)
            {
                if (wallet >= theStore.price25Cups)
                {
                    todayPurchases += theStore.price25Cups;
                    wallet -= theStore.price25Cups;
                }
                else
                {
                    theStore.cupCounter -= 25;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
            else if (theStore.cupsPurchased == 50)
            {
                if (wallet >= theStore.price50Cups)
                {
                    todayPurchases += theStore.price50Cups;
                    wallet -= theStore.price50Cups;
                }
                else
                {
                    theStore.cupCounter -= 50;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
            }
            else if (theStore.cupsPurchased == 100)
            {
                if (wallet >= theStore.price100Cups)
                {
                    todayPurchases += theStore.price100Cups;
                    wallet -= theStore.price100Cups;
                }
                else
                {
                    theStore.cupCounter -= 100;
                    Console.WriteLine("Not enough money in wallet for that purchase.");
                }
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
