using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chetnasuma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double sum1 = 0;
            double sum2 = 0;

            for (int i = 1; i <= num; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum1 += input;
                }
                else
                {
                    sum2 += input;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum - {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1-sum2)}");
            }
        }
    }
}
