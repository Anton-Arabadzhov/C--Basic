using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readwords
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while (true)
            {
                string money = Console.ReadLine();
                if (money == "NoMoreMoney")
                {
                    break;
                }
                double trans = double.Parse(money);
                if (trans<= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += trans;
                Console.WriteLine($"Increase: {trans:f2}");
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
