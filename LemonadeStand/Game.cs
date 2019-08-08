using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        // member variables
        public int cupCounter;
        public int lemonCounter;
        public int sugarCounter;
        public int iceCounter;
        public int dayCounter;
        public int numberOfDays;
        public Day today;
        public Stand lemonadeStand;
        public Store theStore;

        // constructor
        public Game()
        {
            dayCounter = 1;
            numberOfDays = 7;
            today = new Day();
            theStore = new Store();
            lemonadeStand = new Stand();
        }

        // member methods
        public void RunGame()
        {
            DisplayRules();
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            Console.Clear();
            for (int i = 1; i <= numberOfDays; i++)
            {
                DisplayDay();
                lemonadeStand.PurchaseSupplies();
                lemonadeStand.MakePitcherRecipe();
                lemonadeStand.SetLemonadePrice();
                Console.WriteLine("Your lemonade stand is ready!\nPress enter to open for the day");
                Console.ReadLine();
                lemonadeStand.SellLemonade();
                lemonadeStand.EndOfDaySupplies();
                DisplayEndOfDay();

                dayCounter++;
                Console.Clear();
            }
            Console.ReadLine();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Lemonade Stand\nSell lemonade for " + numberOfDays + " days.\nPurchase cups, lemons, sugar, and ice. Make your recipe.\nConsider the weather. Set your price. And try to make a profit!");
        }

        public void DisplayDay()
        {
            Console.WriteLine("Day " + dayCounter + "\n" + today.GetWeather());
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Inventory\nCups: " + lemonadeStand.cupCounter + "\nLemons: " + lemonadeStand.lemonCounter + "\nCups of Sugar: " + lemonadeStand.sugarCounter + "\nIce Cubes: " + lemonadeStand.iceCounter);
        }
        public void DisplayMoney()
        {
            Console.WriteLine("Money: " + lemonadeStand.wallet);
        }

        public void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public void DisplayEndOfDay()
        {
            DisplayInventory();
            DisplayMoney();
        }
    }
}
