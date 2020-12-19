using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counts = int.Parse(Console.ReadLine());

            double time = counts * 3;

            Console.WriteLine($"The architect {name} " +
                $"will need {time} hours to complete {counts} project/s.");
        }
    }
}
