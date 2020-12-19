using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double campPrice = 0.0;
            string destination = "";
            string hotelType = "";
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    campPrice = budget * 0.30;
                    destination = "Bulgaria";
                    hotelType = "Camp";
                }
                
                else if (season == "winter")
                {
                    campPrice = budget * 0.70;
                    destination = "Bulgaria";
                    hotelType = "Hotel";
                }
                
            }
            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    campPrice = budget * 0.40;
                    destination = "Balkans";
                    hotelType = "Camp";
                }
                else if (season == "winter")
                {
                    campPrice = budget * 0.80;
                    destination = "Balkans";
                    hotelType = "Hotel";
                }
                
            }
            else if (budget > 1000)
            {
                campPrice = budget * 0.90;
                destination = "Europe";
                hotelType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{hotelType} - {campPrice:f2}");
        }
    }
}
