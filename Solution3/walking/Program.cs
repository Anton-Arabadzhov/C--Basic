using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            int totalSteps = 0;
            while (stop == false)
            {
                string comand = Console.ReadLine();
                if (comand == "Going home")
                {
                    int oneMore = int.Parse(Console.ReadLine());
                    totalSteps += oneMore;
                    stop = true;
                }
                else
                {
                    int steps = int.Parse(comand);
                    totalSteps += steps;
                    if (totalSteps >= 10000)
                    {
                        stop = true;
                    }
                }
            }
            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
