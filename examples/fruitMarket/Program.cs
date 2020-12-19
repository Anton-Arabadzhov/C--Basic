using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananasWeight = double.Parse(Console.ReadLine());
            double orangesWeight = double.Parse(Console.ReadLine());
            double malinasWeight = double.Parse(Console.ReadLine());
            double strawberryWeight = double.Parse(Console.ReadLine());

            double malinasPrice = strawberryPrice * 0.50;
            double orangesPrice = malinasPrice * 0.60;
            double bananasPrice = malinasPrice * 0.20;

            double moneyneed = strawberryPrice * strawberryWeight + malinasPrice * malinasWeight
                + bananasPrice * bananasWeight + orangesPrice * orangesWeight;

            Console.WriteLine("{0:F2}",moneyneed);
        }
    }
}
