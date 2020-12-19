using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyGel
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int countsFruit = int.Parse(Console.ReadLine());

            double sum = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    sum += (2 * 56) * countsFruit;
                }
                else if (size == "big")
                {
                    sum += (5 * 28.70) * countsFruit;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    sum += (2 * 36.66) * countsFruit;
                }
                else if (size == "big")
                {
                    sum += (5 * 19.60) * countsFruit;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    sum += (2 * 42.10) * countsFruit;
                }
                else if (size == "big")
                {
                    sum += (5 * 24.80) * countsFruit;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    sum += (2 * 20) * countsFruit;
                }
                else if (size == "big")
                {
                    sum += (5 * 15.20) * countsFruit;
                }
            }
            if (sum >= 400 && sum <= 1000)
            {
                sum = sum * 0.85;
            }
            else if (sum > 1000)
            {
                sum = sum * 0.50;
            }
            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}
