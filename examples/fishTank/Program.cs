using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthSm = double.Parse(Console.ReadLine());
            double WidthSm = double.Parse(Console.ReadLine());
            double heightSm = double.Parse(Console.ReadLine());
            double percentUsed = double.Parse(Console.ReadLine());

            double AquariumArea = (lengthSm * WidthSm * heightSm) * 0.001;
            double percent = percentUsed * 0.01;


            Console.WriteLine(AquariumArea - (AquariumArea * percent));
        }
    }
}
