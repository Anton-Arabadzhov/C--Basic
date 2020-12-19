using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n-i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int g  = n-1; g >= 1; g--)
            {
                Console.Write(new string(' ', n - g));
                for (int f = 0; f < g; f++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
