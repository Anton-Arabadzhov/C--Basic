using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            string car = "";
            string clas = "";
            double carRend = 0;


            if (budget <= 100 && season == "Summer")
            {
                car = "Cabrio";
                clas = "Economy class";
                carRend = budget * 0.35;
            }
            else if (budget > 100 && budget <= 500 && season == "Summer")
            {
                car = "Cabrio";
                clas = "Compact class";
                carRend = budget * 0.45;
            }
            else if (budget > 500 && season == "Summer")
            {
                car = "Jeep";
                clas = "Luxury class";
                carRend = budget * 0.90;
            }

            if (budget <= 100 && season == "Winter")
            {
                car = "Jeep";
                clas = "Economy class";
                carRend = budget * 0.65;
            }
            else if (budget > 100 && budget <= 500 && season == "Winter")
            {
                car = "Jeep";
                clas = "Compact class";
                carRend = budget * 0.80;
            }
            else if (budget > 500 && season == "Winter")
            {
                car = "Jeep";
                clas = "Luxury class";
                carRend = budget * 0.90;
            }
            Console.WriteLine(clas);
            Console.WriteLine($"{car} - {carRend:f2}");
        }
    }
}
 