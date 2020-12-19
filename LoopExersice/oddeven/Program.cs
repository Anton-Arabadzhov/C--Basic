using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddeven
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double minOdd = 1000000.0;
            double maxOdd = -1000000.0;
            double minEven = 1000000.0;
            double maxEven = -1000000.0;

            
            for (int i = 0; i < n; i++)
            {
                
                double number = double.Parse(Console.ReadLine());


                
                if (i % 2 == 0)
                {
                    oddSum += number;
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                }
                else
                {
                    evenSum += number;
                    if (number > maxEven )
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    {
                        minEven = number;
                    }
                }
            }

            if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={minOdd:F2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 0)
            {
                Console.WriteLine($"OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
                

            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={minOdd:f2},");
                Console.WriteLine($"OddMax={maxOdd:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={minEven:f2},");
                Console.WriteLine($"EvenMax={maxEven:f2}");
            }
        }
    }
}
