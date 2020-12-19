using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startnumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isSum = false;

            for (int x1 = startnumber; x1 <= endNumber; x1++)
            {
                for (int x2 = startnumber; x2 <= endNumber; x2++)
                {
                    counter++;
                    
                    if (x1 + x2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {magicNumber})");
                        isSum = true;
                        break;
                    }
                   
                }
                if (isSum)
                {
                    break;
                }
            }
            if (!isSum)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
