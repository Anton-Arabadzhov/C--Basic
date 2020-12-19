using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double n = double.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Result: {n * 2:F2}");
                }
            }
        }
    }
}
