using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            double runCounts = 0;


            while (runCounts < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int moresteps = int.Parse(Console.ReadLine());
                    runCounts += moresteps;
                    break;
                }
                int moreSteps = int.Parse(input);
                runCounts += moreSteps;

            }
            if (runCounts >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{runCounts - 10000} steps over the goal!");

            }
            else
            {
                Console.WriteLine($"{10000 - runCounts} more steps to reach goal.");
            }
        }
    }
}
