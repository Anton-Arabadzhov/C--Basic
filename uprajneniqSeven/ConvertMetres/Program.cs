using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMetres
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string timeFrom = Console.ReadLine();
            string timeTo = Console.ReadLine();

            double result = 0;

            if (timeFrom == "mm" && timeTo == "m")
            {
                result = number / 1000;
                Console.WriteLine($"{result:F3}");
            }
            else if (timeFrom == "m" && timeTo == "cm")
            {
                result = number * 100;
                Console.WriteLine($"{result:F3}");
            }
            else if (timeFrom == "cm" && timeTo == "mm")
            {
                result = number * 10;
                Console.WriteLine($"{result:f3}");
            }
            else if (timeFrom == "m" && timeTo == "mm")
            {
                result = number * 1000;
                Console.WriteLine($"{result:f3}");
            }
            else if (timeFrom == "cm" && timeTo == "m")
            {
                result = number / 100;
                Console.WriteLine($"{result:f3}");
            }
            else
            {
                result = number / 10;
                Console.WriteLine($"{result:f3}");
            }
             
            
            
        }
    }
}
