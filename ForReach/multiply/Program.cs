using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    
                }
                else
                {
                    Console.WriteLine($"Result: {number * 2:f2}");
                }
                
            }
        }
    }
}
