using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            int counts = 0;
            double sum = budget;
            while (sum >= 0)
            {
                string item = Console.ReadLine();
                if (item == "Stop")
                {
                    break;
                }
                counts++;
                double price = double.Parse(Console.ReadLine());
                if (counts % 3 == 0)
                {
                    price /= 2;
                }
                sum -= price;
            }
            if (sum >= 0)
            {
                Console.WriteLine($"You bought {counts} products for {budget - sum:f2} leva.") ;
            }
            else
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(sum):f2} leva!");
            }
        }
    }
}
