using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            double area = length * wight * hight;
            double sum = 0;
            while (sum < area)
            {
                string box = Console.ReadLine();
                if (box == "Done")
                {
                    
                    break;
                }
                int boxes = int.Parse(box);
                sum += boxes;
            }
            if (sum < area)
            {
                Console.WriteLine($"{area - sum} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {sum - area} Cubic meters more.");
            }
        }
    }
}
