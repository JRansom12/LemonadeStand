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
            dayCounter = 0;
            today = new Day();
            numberOfDays = 7;
            lemonadeStand = new Stand();
            player1 = new Player();
            theStore = new Store();
        }

        // member methods
        public void RunGame()
        {
            Console.WriteLine("Lemonade Stand");
            DisplayRules();
            DisplayDay();
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseCups(player1.money);
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseLemons(player1.money);
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseSugar(player1.money);
            DisplayInventory();
            DisplayMoney();
            theStore.PurchaseIce(player1.money);
            DisplayInventory();
            DisplayMoney();
            Console.ReadLine();
        }
        public void DisplayRules()
        {
            Console.WriteLine("Sell lemonade for " + numberOfDays + " days.\nPurchase cups, lemons, sugar, and ice. Make your recipe.\nConsider the weather. Set your price. And try to make a profit!");
        }

        public void DisplayDay()
        {
            Console.WriteLine("Day " + dayCounter + "\n" + today.GetWeather());
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Inventory\nCups: " + player1.cupCounter + "\nLemons: " + lemonadeStand.lemonCounter + "\nCups of Sugar: " + lemonadeStand.sugarCounter + "\nIce Cubes: " + lemonadeStand.iceCounter);
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
    }
}
