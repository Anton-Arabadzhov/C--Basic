using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string flat = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double tripPrice = 0.0;
            double totalPrice = 0.0;
            switch (flat)
            {
                case "room for one person":
                    totalPrice = nights * 18;
                   
                    break;
                case "apartment":
                    tripPrice = nights * 25;
                    if (nights < 10)
                    {
                        totalPrice = tripPrice * 0.70;
                    }
                    
                    else if (nights >= 10 && nights <= 15)
                    {
                        totalPrice = tripPrice * 0.65;
                    }
                    else if (nights > 15)
                    {
                        totalPrice = tripPrice * 0.50;
                    }
                    break;
                case "president apartment":
                    tripPrice = nights * 35;
                    if (nights < 10)
                    {
                        totalPrice = tripPrice * 0.90;
                    }

                    else if (nights >= 10 && nights <= 15)
                    {
                        totalPrice = tripPrice * 0.85;
                    }
                    else if (nights > 15)
                    {
                        totalPrice = tripPrice * 0.80;
                    }

                    break;
                   
                    
            }
            if (grade == "positive")
            {
                totalPrice = totalPrice * 1.25;
                Console.WriteLine($"{totalPrice:f2}");
            }
            else if (grade == "negative")
            {
                totalPrice = totalPrice * 0.90;
                Console.WriteLine($"{totalPrice:f2}");
            }
        }

    }
}
