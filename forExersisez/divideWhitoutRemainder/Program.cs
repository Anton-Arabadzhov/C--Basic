using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divideWhitoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 0; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    p1 += 1;
                }
                if (number % 3 == 0)
                {
                    p2 += 1;
                }
                if (number % 4 == 0)
                {
                    p3 += 1;
                }
            }
            double sum = p1 + p2 + p3;
            Console.WriteLine($"{(p1 * 100) / sum}");
            Console.WriteLine($"{(p2 * 100) / sum}");
            Console.WriteLine($"{(p3 * 100) / sum}");
        }
    }
}
