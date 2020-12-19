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
            int num = int.MaxValue;

            while (true)
            {
                string Number = Console.ReadLine();
                if (Number == "Stop")
                {
                    Console.WriteLine(num);
                    break;
                }
                else
                {
                    int nums = int.Parse(Number);
                    if (num >= nums)
                    {
                        num = nums;
                    }
                }
                

            }
            
        }
    }
}
