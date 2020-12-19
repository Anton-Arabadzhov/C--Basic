using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double ns = Math.Floor(n*100);
            double result = 0;

            while (ns != 0)
            {
                if (ns >= 200)
                {
                    ns -= 200;
                    result++;
                }
                else if (ns >= 100)
                {
                    ns -= 100;
                    result++;
                }
                else if (ns >= 50)
                {
                    ns -= 50;
                    result++;
                }
                else if (ns >= 20)
                {
                    ns -= 20;
                    result++;
                }
                else if (ns >= 10)
                {
                    ns -= 10;
                    result++;
                }
                else if (ns >= 5)
                {
                    ns -= 5;
                    result++;
                }
                else if (ns >= 2)
                {
                    ns -= 2;
                    result++;
                }
                else if (ns >= 1)
                {
                    ns -= 1;
                    result++;
                }
            }
            Console.WriteLine(result);
            
        }
    }
}
