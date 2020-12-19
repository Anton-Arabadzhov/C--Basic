using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forcc
{
    class Program
    {
        static void Main(string[] args)
        {
            int ages = int.Parse(Console.ReadLine());
            double washer = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

           
            double toysN = 0;
            double allsum = 0;
            
            
            for (int i = 1; i <= ages; i++)
            {
                if (i % 2 != 0)
                {
                    toysN += toysPrice;
                }
                else
                {
                    allsum += i * 5 - 1;
                }
            }
            double allSumneed = allsum + toysN;
            if (allSumneed >= washer)
            {
                
                double N = allSumneed - washer;
                Console.WriteLine($"Yes! {N:f2}");
            }
            else
            {
                double M = washer - allSumneed;
                Console.WriteLine($"No! {M:f2}");
            }
        }
    }
}
