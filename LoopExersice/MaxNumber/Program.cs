using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number < max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
