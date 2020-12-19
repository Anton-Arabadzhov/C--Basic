using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd3

{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double result = Math.Pow(i, n);
                Console.WriteLine(result);
            }
        }
    }
}
