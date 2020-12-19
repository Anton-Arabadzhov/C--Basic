using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double areaForWine = (x * y) * 0.40;
            double wineLitres = areaForWine / 2.5;
            double litresNeed = wineLitres - z;
            double literPerWorker = litresNeed / workers;

            if (wineLitres < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Abs(Math.Truncate(litresNeed))} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(wineLitres)} liters.");
                Console.WriteLine($"{Math.Ceiling(litresNeed)} liters left -> {Math.Ceiling(literPerWorker)} liters per person.");
            }

        }
    }
}
