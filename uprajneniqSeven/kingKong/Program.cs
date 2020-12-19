using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double equipment = double.Parse(Console.ReadLine());

            double decorate = budget * 0.10;
            double allequip = 0;
            double moneyforFilm = 0;

            if (statists > 150)
            {
                allequip = (statists * equipment) * 0.90;
                moneyforFilm = allequip + decorate;
            }
            else
            {
                allequip = statists * equipment;
                moneyforFilm = allequip + decorate;
            }
            if (moneyforFilm > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyforFilm - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneyforFilm:f2} leva left.");
            }
        }
    }
}
