using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                double inputs = double.Parse(Console.ReadLine());

                double num1 = 0;
                double num2 = 0;
                double num3 = 0;

                for (int number = 1; number <= inputs; number++)
            {
                    double input = double.Parse(Console.ReadLine());

                    if (input % 2 == 0)
                    {
                        num1++;
                    }
                    if (input % 3 == 0)
                    {
                        num2++;
                    }
                    if (input % 4 == 0)
                    {
                        num3++;
                    }

            }
                double num1Percent = (num1 / inputs) * 100.0;
                double num2Percent = (num2 / inputs) * 100.0;
                double num3Percent = (num3 / inputs) * 100.0;
                Console.WriteLine($"{num1Percent:f2}%");
                Console.WriteLine($"{num2Percent:f2}%");
                Console.WriteLine($"{num3Percent:f2}%");
            
        }
    }


}
    

