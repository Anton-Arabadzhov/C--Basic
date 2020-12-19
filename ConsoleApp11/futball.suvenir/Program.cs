using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futball.suvenir
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string tip = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double moneySpent = 0;
            double itemPrice = 0;
            switch (team)
            {
                case "Argentina":
                    switch (tip)
                    {
                        case "flags": itemPrice = 3.25; break;
                        case "caps": itemPrice = 7.20; break;
                        case "posters": itemPrice = 5.10; break;
                        case "stickers": itemPrice = 1.25; break;
                        default: Console.WriteLine("Invalid stock!"); break;
                    } break;
                case "Brazil":
                    switch (tip)
                    {
                        case "flags": itemPrice = 4.20; break;
                        case "caps": itemPrice = 8.50; break;
                        case "posters": itemPrice = 5.35; break;
                        case "stickers": itemPrice = 1.20; break;
                        default: Console.WriteLine("Invalid stock!"); break;
                    }
                    break;
                case "Croatia":
                    switch (tip)
                    {
                        case "flags": itemPrice = 2.75; break;
                        case "caps": itemPrice = 6.90; break;
                        case "posters": itemPrice = 4.95; break;
                        case "stickers": itemPrice = 1.10; break;
                        default: Console.WriteLine("Invalid stock!"); break;
                    }
                    break;
                case "Denmark":
                    switch (tip)
                    {
                        case "flags": itemPrice = 3.10; break;
                        case "caps": itemPrice = 6.50; break;
                        case "posters": itemPrice = 4.80; break;
                        case "stickers": itemPrice = 0.90; break;
                        default: Console.WriteLine("Invalid stock!"); break;
                    }
                    break;
                default: Console.WriteLine("Invalid country!"); break;
                    
            }
            moneySpent = count * itemPrice;
            if (itemPrice != 0)
            {
                Console.WriteLine($"Pepi bought {count} {tip} of {team} for {moneySpent:F2} lv.");
            }
            
        }
    }
} 
