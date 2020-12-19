using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            int olnDoggs = int.Parse(Console.ReadLine());
            int otherDoggs = int.Parse(Console.ReadLine());

            double doggFoodPrice = olnDoggs * 2.50;
            double otherFoodPrice = otherDoggs * 4;

            Console.WriteLine($"{doggFoodPrice + otherFoodPrice} lv.");

        }
    }
}
