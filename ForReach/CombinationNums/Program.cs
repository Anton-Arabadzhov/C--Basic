using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magicnumber = int.Parse(Console.ReadLine());

            int Counter =0;
            bool found = false;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    int sum = i + j;
                    Counter++;
                    if (sum == magicnumber)
                    {
                        Console.WriteLine($"Combination N:{Counter} ({i} + {j} = {sum})");
                        found = true;
                        break;
                        
                    }
                }
                if (found)
                {
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"{Counter} combinations - neither equals {magicnumber}");
            }
        }
    }
}
