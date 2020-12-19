using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vege = int.Parse(Console.ReadLine());

            double chickenMenus = chicken * 10.35;
            double fishMenus = fish * 12.40;
            double vegeMenus = vege * 8.15;
            double allFoodPrice = chickenMenus + fishMenus + vegeMenus;
            double desert = allFoodPrice * 1.20;
            double finalPrice = allFoodPrice * 1.20 + 2.50;

            Console.WriteLine($"Total: {finalPrice:f2}");

        }
    }
}
