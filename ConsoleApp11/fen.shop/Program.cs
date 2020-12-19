using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fen.shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int counts = int.Parse(Console.ReadLine());

            

            for (int numberCount = 0; numberCount < counts; numberCount++)
            {
                string count = Console.ReadLine();

                switch (count)
                {
                    case "hoodie": budget -= 30; break;
                    case "keychain": budget -= 4; break;
                    case "T-shirt": budget -= 20; break;
                    case "flag": budget -= 15; break;
                    case "sticker": budget -= 1; break;
                }

            }
            if (budget >= 0)
            {
                Console.WriteLine($"You bought {counts} items and left with {budget} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {budget * -1} more lv.");
            }
        }
    }
}
