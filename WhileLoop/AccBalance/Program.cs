using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double number = double.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                total += number;
                Console.WriteLine($"Increase: {number:f2}");
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
