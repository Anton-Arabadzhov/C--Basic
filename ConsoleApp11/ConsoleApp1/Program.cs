using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beersCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double totalBeerPrice = beersCount * 1.2;
            double chipsPrice = totalBeerPrice * 0.45;
            double totalCipsPrice = Math.Ceiling(chipsPrice * chipsCount);
            
            double totalPrice = totalBeerPrice + totalCipsPrice;
            double restMoney = budget - totalPrice;
            double needMoney = totalPrice - budget;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"{name} bought a snack and has {restMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {needMoney:F2} more leva!");
            }
        }
    }
}
