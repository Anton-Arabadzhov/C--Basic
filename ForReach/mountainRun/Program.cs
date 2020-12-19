using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double mountainMetres = double.Parse(Console.ReadLine());
            double secondsForMeter = double.Parse(Console.ReadLine());

            double timeForMetres = mountainMetres * secondsForMeter;
            double slowTime = Math.Floor(mountainMetres / 50) * 30;
            double timeToBeUp = timeForMetres + slowTime;

            if (timeToBeUp >= worldRecord)
            {
                Console.WriteLine($"No! He was {timeToBeUp - worldRecord:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes! The new record is {timeToBeUp:f2} seconds.");
            }
        }
    }
}
