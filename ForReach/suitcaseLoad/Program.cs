using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suitcaseLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double freeSpace = double.Parse(Console.ReadLine());

            double spaceLeft = 0.0;
            double suitcases = 0;

            while (spaceLeft < freeSpace)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                double suitcase = double.Parse(input);
                suitcases++;
                if (suitcases % 3 == 0)
                {
                    suitcase = suitcase * 1.10;
                }
                spaceLeft += suitcase;

            }
            if (freeSpace >= spaceLeft)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
                Console.WriteLine($"Statistic: {suitcases} suitcases loaded.");
            }
            else
            {
                Console.WriteLine($"No more space!");
                Console.WriteLine($"Statistic: {suitcases - 1} suitcases loaded.");
            }
        }
    }
}
