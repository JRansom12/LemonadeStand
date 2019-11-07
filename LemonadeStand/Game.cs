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
        public double todaysProfit;
        public double overallProfit;
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
                lemonadeStand.DisplayInventory();
                lemonadeStand.DisplayMoney();
                lemonadeStand.MakePurchases();
                lemonadeStand.MakePitcherRecipe();
                lemonadeStand.SetLemonadePrice();
                Console.WriteLine("Your lemonade stand is ready!\nPress enter to open for the day");
                DisplayRealWeather();
                Console.ReadLine();
                SellLemonade();
                lemonadeStand.EndOfDaySupplies();
                DisplayProfit();
                dayCounter++;
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("You've completed " + numberOfDays + " days at your lemonade stand! You made $" + overallProfit);
            Console.ReadLine();
        }

        public void SellLemonade()
        {
            today.GenerateCustomers();
            lemonadeStand.MakePitcher();
            for (int i = 0; i < today.customerList.Count; i++)
            {
                lemonadeStand.totalCupsPurchased++;
                lemonadeStand.theStore.cupCounter--;
                lemonadeStand.wallet += lemonadeStand.lemonadePrice;
                lemonadeStand.cupsPurchasedToday++;
                if (lemonadeStand.cupsPurchasedToday == lemonadeStand.cupsPerPitcher)
                {
                    lemonadeStand.MakePitcher();
                    lemonadeStand.cupsPurchasedToday = 0;
                }
            }
        }

        public void DisplayProfit()
        {
            todaysProfit = lemonadeStand.totalCupsPurchased * lemonadeStand.lemonadePrice - lemonadeStand.todayPurchases;
            Console.WriteLine("Today's profit is $" + todaysProfit);
            overallProfit += todaysProfit;
            Console.WriteLine("Overall profit is $" + overallProfit);
            lemonadeStand.todayPurchases = 0;
            lemonadeStand.totalCupsPurchased = 0;
        }

        public void DisplayRules()
        {
            Console.WriteLine("Lemonade Stand\nSell lemonade for " + numberOfDays + " days.\nPurchase cups, lemons, sugar, and ice. Make your recipe.\nConsider the weather. Set your price. And try to make a profit!");
        }

        public void DisplayDay()
        {
            today.GetWeather();
            Console.WriteLine("Day " + dayCounter + "\nForecast is " + today.GetWeatherman());
        }
        public void DisplayRealWeather()
        {
            Console.WriteLine("Weather is " + today.weather.temperature + " degrees and " + today.weather.forecast);
        }
        public void DisplayMoney()
        {
            Console.WriteLine("Money: " + lemonadeStand.wallet.ToString("#.00"));
        }

        public void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
