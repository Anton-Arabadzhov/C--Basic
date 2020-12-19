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
            double walking = 0;

            while (walking < 10000)
            {
                string walkOut = (Console.ReadLine());
                
                if (walkOut == "Going home")
                {
                    int distance = int.Parse(Console.ReadLine());
                    walking += distance;
                    break;
                    
                }
                int walk = int.Parse(walkOut);
                walking += walk;


            }
            if (walking >= 10000)
            {
                double overWalk = walking - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{overWalk} steps over the goal!");
            }
            else
            {
                double result = 10000 - walking;
                Console.WriteLine($"{result} more steps to reach goal.");
            }
            

        }
    }
}
