using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int counts = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0.0;
            
            switch (flowersType)
            {
                case "Roses":
                    totalPrice = counts * 5;
                    if (counts > 80)
                    {
                        totalPrice = totalPrice * 0.90;
                    }
                    break;
                case "Dahlias":
                    totalPrice = counts * 3.80;
                    if (counts > 90)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                    break;
                case "Tulips":
                    totalPrice = counts * 2.80;
                    if (counts > 80)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                    break;
                case "Narcissus":
                    totalPrice = counts * 3;
                    if (counts < 120)
                    {
                        totalPrice = totalPrice * 1.15;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = counts * 2.50;
                    if (counts < 80)
                    {
                        totalPrice = totalPrice * 1.20;
                    }
                    break;
                
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {counts} {flowersType} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
