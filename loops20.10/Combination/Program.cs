using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger f = 1, i, x = 4, z = 1, j, y, d = 1;
            BigInteger k = n + 4;
            for (y = 1; y <= n; y++)
            {
                d *= y;
            }
            for (i = 1; i <= k; i++)
            {
                f *= i;
            }


            for (j = 1; j <= x; j++)
            {
                z *= j;
            }

            BigInteger formula2 = d * z;
            BigInteger formula1 = f / formula2;
            Console.WriteLine(formula1);
        }
    }
}
