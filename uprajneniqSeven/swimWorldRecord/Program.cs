using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swimWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double Record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerSec = double.Parse(Console.ReadLine());

            double distanceSec = distance * timePerSec;
            double totalDistanceSec = Math.Floor(distance / 15) * 12.5;
            double totalTime = distanceSec + totalDistanceSec;

            if (totalTime >= Record)
            {
                Console.WriteLine($"No, he failed! He was {totalTime - Record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

        }
    }
}
