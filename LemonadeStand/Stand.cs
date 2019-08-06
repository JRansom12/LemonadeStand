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
        // constructor
        public Stand()
        {
            cupCounter = 0;
            lemonCounter = 0;
            sugarCounter = 0;
            iceCounter = 0;
            lemonsInPitcher = 5;
            sugarInPitcher = 5;
            iceCubesInCup = 5;
        }

        // member methods
        public void DisplayInventory()
        {
            Console.WriteLine("Cups: " + cupCounter + "\nLemons: " + lemonCounter + "\nCups of Sugar: " + sugarCounter + "\nIce Cubes: " + iceCounter);
        }
        public void MakePitcher()
        {
            ChooseLemons();
            ChooseSugar();
            ChooseIce();
        }
        public void ChooseLemons()
        {
            Console.WriteLine("Make your lemonade recipe!\nHow many lemons?");
            lemonsInPitcher = Convert.ToInt32(Console.ReadLine());
            lemonCounter -= lemonsInPitcher;
        }
        public void ChooseSugar()
        {
            Console.WriteLine("How many cups of sugar?");
            sugarInPitcher = Convert.ToInt32(Console.ReadLine());
            sugarCounter -= sugarInPitcher;
        }
        public int ChooseIce()
        {
            Console.WriteLine("How many ice cubes per cup?");
            iceCubesInCup = Convert.ToInt32(Console.ReadLine());
            if (iceCubesInCup < 2)
            {
                iceCounter -= 8 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 2 && iceCubesInCup < 4)
            {
                iceCounter -= 9 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 4 && iceCubesInCup < 6)
            {
                iceCounter -= 10 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 6 && iceCubesInCup < 8)
            {
                iceCounter -= 11 * iceCubesInCup;
            }
            else if (iceCubesInCup >= 8 && iceCubesInCup < 10)
            {
                iceCounter -= 12 * iceCubesInCup;
            }
            else
            {
                Console.WriteLine("Can't fit 10 or more ice cubes in a cup, sorry. Please choose a smaller number.");
                ChooseIce();
            }
            return iceCubesInCup;
        }
    }
}
