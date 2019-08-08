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
        public int price;
        public int expenses;
        public int profit;
        public int cupCounter;
        public int lemonCounter;
        public int sugarCounter;
        public int iceCounter;
        public int lemonsInPitcher;
        public int sugarInPitcher;
        public int iceCubesInCup;
        public int cupsPerPitcher;
        public double lemonadePrice;
        public Player player1;
        public Day today;

        // constructor
        public Stand()
        {
            today = new Day();
            cupCounter = 50;
            lemonCounter = 30;
            sugarCounter = 20;
            iceCounter = 250;
            lemonsInPitcher = 4;
            sugarInPitcher = 4;
            iceCubesInCup = 4;
            cupsPerPitcher = 10;
            lemonadePrice = .25;
            player1 = new Player();
        }

        // member methods
        public void DisplayInventory()
        {
            Console.WriteLine("Cups: " + cupCounter + "\nLemons: " + lemonCounter + "\nCups of Sugar: " + sugarCounter + "\nIce Cubes: " + iceCounter);
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
            iceCubesInCup = Convert.ToInt32(Console.ReadLine());
            return iceCubesInCup;
            //if (iceCubesInCup <= 10)
            //{
            //    return iceCubesInCup;
            //}
            //else
            //{
            //    Console.WriteLine("Can't fit 10 or more ice cubes in a cup, sorry. Please choose a smaller number.");
            //    ChooseIce();
            //}
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
            cupCounter -= cupsPerPitcher;
            return cupCounter;
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
            today.CustomersPurchase();
            today.MoneyMade();
        }
        public void EndOfDaySupplies()
        {
            Console.WriteLine("Your remaining ice has melted.");
            iceCounter = 0;
            player1.money += today.moneyMade;
            DisplayInventory();
        }
    }
}
