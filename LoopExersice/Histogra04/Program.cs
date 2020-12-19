using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogra04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 200)
                {
                    p1++;
                }
                else if (input >= 200 && input < 400)
                {
                    p2++;
                }
                else if (input >= 400 && input < 600)
                {
                    p3++;
                }
                else if (input >= 600 && input < 800)
                {
                    p4++;
                }
                else if (input >= 800)
                {
                    p5++;
                }
            }

            Console.WriteLine($"{(p1 / n) * 100:F2}%");
            Console.WriteLine($"{(p2 / n) * 100:F2}%");
            Console.WriteLine($"{(p3 / n) * 100:F2}%");
            Console.WriteLine($"{(p4 / n) * 100:F2}%");
            Console.WriteLine($"{(p5 / n) * 100:F2}%");
        }
    }
}
