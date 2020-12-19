using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dishWasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottleChemical = int.Parse(Console.ReadLine());

            double chemicalMl = bottleChemical * 750;
            int dish = 0;
            int pan = 0;
            int counter = 0;
            double sum = 0;

            while (chemicalMl >= sum)
            {
                string n = (Console.ReadLine());

                if (n == "End")
                {
                    break;
                }
                int num = int.Parse(n);
                counter++;
                if (counter % 3 != 0)
                {
                    sum += num * 5;
                    dish += num;
                }
                else
                {
                    sum += num * 15;
                    pan += num;
                }

            }
            if (sum <= chemicalMl)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dish} dishes and {pan} pots were washed.");
                Console.WriteLine($"Leftover detergent {Math.Abs(sum - chemicalMl)} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(sum - chemicalMl)} ml. more necessary!");
            }
        }
    }
}
