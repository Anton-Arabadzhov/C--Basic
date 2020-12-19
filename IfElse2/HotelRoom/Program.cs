using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounts = Console.ReadLine();
            double nights = int.Parse(Console.ReadLine());

            double resultStudio = 0.0;
            double resultFlat = 0.0;
            if (mounts == "May" || mounts == "October")
            {
                
                if (nights > 7 && nights <= 14)
                {
                    resultStudio = (nights * 50) * 0.95;
                    resultFlat = nights * 65;
                }
                else if (nights > 14)
                {
                    resultStudio = (nights * 50) * 0.70;
                    resultFlat = (nights * 65) * 0.90;
                }
                else
                {
                    resultStudio = (nights * 50);
                    resultFlat = nights * 65;
                }
                
            
            }
            else if (mounts == "June" || mounts == "September")
            {
                if (nights > 14)
                {
                    resultStudio = (nights * 75.20) * 0.80;
                    resultFlat = (nights * 68.70) * 0.90;
                }
                else
                {
                    resultStudio = (nights * 75.20);
                    resultFlat = nights * 68.70;
                }
            }
            else if (mounts == "July" || mounts == "August")
            {
                
                if (nights > 14)
                {
                    resultFlat = (nights * 77) * 0.90;
                    resultStudio = (nights * 76);
                }
                else
                {
                    resultStudio = (nights * 76);
                    resultFlat = nights * 77;
                }
            }
            Console.WriteLine($"Apartment: {resultFlat:f2} lv.");
            Console.WriteLine($"Studio: {resultStudio:f2} lv.");
        }
    }
}
