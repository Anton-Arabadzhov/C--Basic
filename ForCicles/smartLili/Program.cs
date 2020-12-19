using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double clothWasher = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            double allMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    allMoney += i * 5 -1;
                }
                else
                {
                    allMoney += toysPrice;
                }
            }
            if (allMoney >= clothWasher)
            {
                Console.WriteLine($"Yes! {allMoney - clothWasher:f2}");
            }
            else
            {
                Console.WriteLine($"No! {clothWasher - allMoney:f2}");
            }
        }
    }
}
