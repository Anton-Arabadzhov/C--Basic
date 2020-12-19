using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litres = double.Parse(Console.ReadLine());
            string clucard = Console.ReadLine();

            double sum = 0;

            if (fuel == "Gas" && clucard == "Yes")
            {
                sum = litres * 0.85;

            }
            else if (fuel == "Gas" && clucard == "No")
            {
                sum = litres * 0.93;
            }

            else if (fuel == "Gasoline" && clucard == "Yes")
            {
                sum = litres * 2.04;
            }
            else if (fuel == "Gasoline" && clucard == "No")
            {
                sum = litres * 2.22;
            }
            else if (fuel == "Diesel" && clucard == "Yes")
            {
                sum = litres * 2.21;
            }
            else if (fuel == "Diesel" && clucard == "No")
            {
                sum = litres * 2.33;
            }
            if (litres >= 20 && litres <= 25)
            {
                
                sum = sum * 0.92;
            }
            else if (litres > 25)
            {
                sum = sum * 0.90;
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
