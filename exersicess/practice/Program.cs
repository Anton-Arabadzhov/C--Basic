using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int workDays = 365 - holidays;
            double minutes = workDays * 63 + holidays * 127;
            double minutesleft = Math.Abs(30000 - minutes);
            double hours = minutesleft / 60;
            
            double hMinutes = minutesleft % 60;

            if (minutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Truncate(hours)} hours and {hMinutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Truncate(hours)} hours and {hMinutes} minutes less for play");
            }

        }
    }
}
