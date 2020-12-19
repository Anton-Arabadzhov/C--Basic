using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string cinemaType = Console.ReadLine();
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            double sitArea = sideA * sideB;
            double finalPrice = 0.0;

            if (cinemaType == "Premiere")
            {
                finalPrice = sitArea * 12;
            }
            else if (cinemaType == "Normal")
            {
                finalPrice = sitArea * 7.50;
            }
            else if (cinemaType == "Discount")
            {
                finalPrice = sitArea * 5;
            }
            Console.WriteLine($"{finalPrice:f2} leva");
        }
    }
}
