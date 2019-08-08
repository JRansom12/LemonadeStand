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
        public Player player1;
        public List<int> days;
        public Day today;
        public Stand lemonadeStand;
        public Store theStore;

        // constructor
        public Game()
        {
            cupCounter = 0;
            lemonCounter = 0;
            sugarCounter = 0;
            iceCounter = 0;
            days = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            dayCounter = 1;
            today = new Day();
            numberOfDays = 7;
            lemonadeStand = new Stand();
            player1 = new Player();
            theStore = new Store();
        }

        // member methods
        public void RunGame()
        {
            DisplayRules();
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            Console.Clear();
            //while
            DisplayDay();
            PurchaseSupplies();
            lemonadeStand.MakePitcherRecipe();
            lemonadeStand.SetLemonadePrice();
            Console.WriteLine("Your lemonade stand is ready!\nPress enter to open for the day");
            Console.ReadLine();
            lemonadeStand.SellLemonade();
            DisplayEndOfDay();

            dayCounter++;
            Console.Clear();
        }

        public void PurchaseSupplies()
        {
            lemonadeStand.DisplayInventory();
            DisplayMoney();
            theStore.PurchaseCups();
            lemonadeStand.DisplayInventory();
            DisplayMoney();
            theStore.PurchaseLemons();
            lemonadeStand.DisplayInventory();
            DisplayMoney();
            theStore.PurchaseSugar();
            lemonadeStand.DisplayInventory();
            DisplayMoney();
            theStore.PurchaseIce();
            lemonadeStand.DisplayInventory();
            DisplayMoney();
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
            Console.WriteLine("Money: " + player1.money);
        }

        public void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        public void DisplayEndOfDay()
        {

        }
    }
}
