using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)

        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string place = "";
            string house = "";
            double money = 0;

            if (budget <= 1000 && season == "Summer")
            {
                place = "Alaska";
                house = "Camp";
                money = budget * 0.65;
            }
            else if (budget >= 1000 && budget <= 3000 && season == "Summer")
            {
                place = "Alaska";
                house = "Hut";
                money = budget * 0.80;
            }
            else if (budget > 3000 && season == "Summer")
            {
                place = "Alaska";
                house = "Hotel";
                money = budget * 0.90;
            }

            if (budget <= 1000 && season == "Winter")
            {
                place = "Morocco";
                house = "Camp";
                money = budget * 0.45;
            }
            else if (budget >= 1000 && budget <= 3000 && season == "Winter")
            {
                place = "Morocco";
                house = "Hut";
                money = budget * 0.60;
            }
            else if (budget > 3000 && season == "Winter")
            {
                place = "Morocco";
                house = "Hotel";
                money = budget * 0.90;
            }
            Console.WriteLine($"{place} - {house} - {money:f2}");
        }
    }
}
