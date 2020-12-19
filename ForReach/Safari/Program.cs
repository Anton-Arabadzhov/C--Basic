using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double fuelNeed = fuel * 2.10;
            double moneyNeed = fuelNeed + 100;
            if (day == "Saturday")
            {
                moneyNeed *= 0.90;
                
            }
            else if (day == "Sunday")
            {
                moneyNeed *= 0.80;
            }
            if (budget < moneyNeed)
            {
                Console.WriteLine($"Not enough money! Money needed: {moneyNeed - budget:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Safari time! Money left: {budget - moneyNeed:f2} lv. ");
            }
        }
    }
}
