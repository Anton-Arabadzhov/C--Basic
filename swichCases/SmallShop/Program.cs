using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double counts = double.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            switch (town)
            {
                case "Sofia":
                    if (product == "coffee")
                    {
                        totalPrice = counts * 0.5;
                    }
                    else if (product == "water")
                    {
                        totalPrice = counts * 0.8;
                    }
                    else if (product == "beer")
                    {
                        totalPrice = counts * 1.20;
                    }
                    else if (product == "sweets")
                    {
                        totalPrice = counts * 1.45;
                    }
                    else if (product == "peanuts")
                    {
                        totalPrice = counts * 1.60;
                    }
                    Console.WriteLine(totalPrice);
                    break;
                case "Plovdiv":
                    if (product == "coffee")
                    {
                        totalPrice = counts * 0.4;
                    }
                    else if (product == "water")
                    {
                        totalPrice = counts * 0.7;
                    }
                    else if (product == "beer")
                    {
                        totalPrice = counts * 1.15;
                    }
                    else if (product == "sweets")
                    {
                        totalPrice = counts * 1.30;
                    }
                    else if (product == "peanuts")
                    {
                        totalPrice = counts * 1.5;
                    }
                    Console.WriteLine(totalPrice);
                    break;
                    
                case "Varna":
                    if (product == "coffee")
                    {
                        totalPrice = counts * 0.45;
                    }
                    else if (product == "water")
                    {
                        totalPrice = counts * 0.7;
                    }
                    else if (product == "beer")
                    {
                        totalPrice = counts * 1.10;
                    }
                    else if (product == "sweets")
                    {
                        totalPrice = counts * 1.35;
                    }
                    else if (product == "peanuts")
                    {
                        totalPrice = counts * 1.55;
                    }
                    Console.WriteLine(totalPrice);
                    break;

            }
        }
    }
}
