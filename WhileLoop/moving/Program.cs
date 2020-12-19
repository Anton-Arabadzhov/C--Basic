using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengh = int.Parse(Console.ReadLine());
            int wigth = int.Parse(Console.ReadLine());
            int heigh = int.Parse(Console.ReadLine());

            int area = lengh * wigth * heigh;
            double boxes = 0;

            while (true)
            {
                string box = Console.ReadLine();
                if (box == "Done")
                {
                    double haveSpace = area - boxes;
                    Console.WriteLine($"{haveSpace} Cubic meters left.");
                    break;
                }
                double imput = double.Parse(box);
                boxes += imput;
                if (boxes > area)
                {
                    double needSpace = boxes - area;
                    Console.WriteLine($"No more free space! You need {needSpace} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
