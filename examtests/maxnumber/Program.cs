using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double firstsum = 0;
            double secondsum = 0;

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstsum += num;
            }
            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondsum += num;
            }
            if (firstsum == secondsum)
            {
                Console.WriteLine($"Yes, sum = {firstsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstsum-secondsum)}");
            }
        }

    }
}
