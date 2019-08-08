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
        public int cupCounter;
        public int lemonCounter;
        public int sugarCounter;
        public int iceCounter;
        public int lemonsInPitcher;
        public int sugarInPitcher;
        public int iceCubesInCup;
        public int cupsPerPitcher;
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
            lemonCounter -= lemonsInPitcher;
            return lemonCounter;
        }
        public int ChooseSugar()
        {
            Console.WriteLine("How many cups of sugar?");
            sugarInPitcher = Convert.ToInt32(Console.ReadLine());
            return sugarInPitcher;
        }
        public int AddSugar()
        {
            sugarCounter -= sugarInPitcher;
            return sugarCounter;
        }
        public int ChooseIce()
        {
            Console.WriteLine("How many ice cubes per cup?");
            iceCubesInCup = int.Parse(Console.ReadLine());
            if (iceCubesInCup <= 10)
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
                iceCounter -= 8 * iceCubesInCup;
                return iceCounter;
            }
            else if (iceCubesInCup >= 2 && iceCubesInCup < 4)
            {
                iceCounter -= 9 * iceCubesInCup;
                return iceCounter;
            }
            else if (iceCubesInCup >= 4 && iceCubesInCup < 6)
            {
                iceCounter -= 10 * iceCubesInCup;
                return iceCounter;
            }
            else if (iceCubesInCup >= 6 && iceCubesInCup < 8)
            {
                iceCounter -= 11 * iceCubesInCup;
                return iceCounter;
            }
            else if (iceCubesInCup >= 8 && iceCubesInCup < 10)
            {
                iceCounter -= 12 * iceCubesInCup;
                return iceCounter;
            }
            else
            {
                return iceCounter;
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
                wallet -= .80;
                return wallet;
            }
            else if (theStore.lemonsPurchased == 30)
            {
                wallet -= 2.10;
                return wallet;
            }
            else if (theStore.lemonsPurchased == 75)
            {
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
                wallet -= .56;
                return wallet;
            }
            else if(theStore.sugarPurchased == 20)
            {
                wallet -= 1.50;
                return wallet;
            }
            else if(theStore.sugarPurchased == 48)
            {
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
                wallet -= .95;
                return wallet;
            }
            else if(theStore.icePurchased == 250)
            {
                wallet -= 2.25;
                return wallet;
            }
            else if(theStore.icePurchased == 500)
            {
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
                wallet -= .90;
                return wallet;
            }
            else if(theStore.cupsPurchased == 50)
            {
                wallet -= 1.60;
                return wallet;
            }
            else if(theStore.cupsPurchased == 100)
            {
                wallet -= 2.80;
                return wallet;
            }
            else
            {
                return wallet;
            }
        }
        public void PurchaseSupplies()
        {
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseCups();
            PayForCups();
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseLemons();
            PayForLemons();
            DisplayInventory();
            DisplayMoney();
            theStore.GetSugar();
            PayForSugar();
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseIce();
            PayForIce();
            DisplayInventory();
            DisplayMoney();
        }
        public void MakePitcher()
        {
            AddLemons();
            AddSugar();
            AddIce();
            AddCups();
        }
        public void SellLemonade()
        {
            MakePitcher();
        }
        public void EndOfDaySupplies()
        {
            Console.WriteLine("Your remaining ice has melted.");
            theStore.iceCounter = 0;
            DisplayInventory();
            DisplayMoney();
            Console.ReadLine();
        }
    }
}
