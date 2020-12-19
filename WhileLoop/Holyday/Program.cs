using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holyday
{
    class Program
    {
        static void Main(string[] args)
        {
            double holydayPrice = double.Parse(Console.ReadLine());
            double moneyStart = double.Parse(Console.ReadLine());

            double spendCounts = 0;
            double daysCounter= 0;

            while (moneyStart < holydayPrice && spendCounts <5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;
                if (command == "save")
                {
                    moneyStart += money;
                    spendCounts = 0;
                }
                else if (command == "spend")
                {
                    spendCounts++;
                    moneyStart -= money;
                    if (moneyStart < 0)
                    {
                        moneyStart = 0;
                    }
                }
                if (spendCounts == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCounter);
                }
                if (moneyStart >= holydayPrice)
                {
                    Console.WriteLine($"You saved the money for {daysCounter} days.");
                }
            }
            
        }
    }
}
