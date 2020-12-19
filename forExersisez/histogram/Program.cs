using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > 0 && number < 200)
                {
                    p1 += 1;
                }
                else if (number >= 200 && number < 400)
                {
                    p2 += 1;
                }
                else if (number >= 400 && number < 600)
                {
                    p3 += 1;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4 += 1;
                }
                else if (number >= 800 && number <= 1000)
                {
                    p5 += 1;
                }
                
            }
            double summ = p1 + p2 + p3 + p4 + p5;
            Console.WriteLine($"{(p1 * 100) / summ:f2}%");
            Console.WriteLine($"{(p2 * 100) / summ:f2}%");
            Console.WriteLine($"{(p3 * 100) / summ:f2}%");
            Console.WriteLine($"{(p4 * 100) / summ:f2}%");
            Console.WriteLine($"{(p5 * 100) / summ:f2}%");
        }
    }
}
