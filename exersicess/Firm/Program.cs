using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int overworkers = int.Parse(Console.ReadLine());

            double hoursHave = (days * 0.90) * 8;
            double overtime = overworkers * 2 * days;
            double allTime = hoursHave + overtime;
            double timeleft = allTime - hoursNeeded;
            double timeneed = hoursNeeded - allTime;

            if (allTime >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{Math.Truncate(timeleft)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(timeneed)} hours needed.");
            }
        }
    }
}
