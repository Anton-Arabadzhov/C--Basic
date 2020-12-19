using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acount_balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());
            int counter = 1;
            double currentSum = 0;

            while (counter <= entries)
            {
                double income = double.Parse(Console.ReadLine());
                if (income < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    currentSum += income;
                    Console.WriteLine($"Increase: {income:f2}");
                }
                counter++;
            }
            Console.WriteLine($"Total: {currentSum}");
        }
    }
}
