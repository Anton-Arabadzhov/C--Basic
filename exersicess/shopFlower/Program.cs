using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopFlower
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemas = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int lale = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();

            double hrizantemasPrice = 0;
            double rosePrice = 0;
            double lalePrice = 0;
            double allflowers = hrizantemas + rose + lale;
            double sum = hrizantemasPrice + rosePrice + lalePrice;

            if (season == "Spring")
            {
                hrizantemasPrice = hrizantemas * 2;
                rosePrice = rose * 4.1;
                lalePrice = lale * 2.5;
                if (day == "Y")
                {
                    sum = (hrizantemasPrice + rosePrice + lalePrice) * 1.15;
                }
                else if (day == "N")
                {
                    sum = hrizantemasPrice + rosePrice + lalePrice;
                }
                if (lale > 7)
                {
                    sum = sum * 0.95;
                }
            }
            else if (season == "Summer")
            {
                hrizantemasPrice = hrizantemas * 2;
                rosePrice = rose * 4.1;
                lalePrice = lale * 2.5;
                if (day == "Y")
                {
                    sum = (hrizantemasPrice + rosePrice + lalePrice) * 1.15;
                }
                else if (day == "N")
                {
                    sum = hrizantemasPrice + rosePrice + lalePrice;
                }
            }
            else if (season == "Autumn")
            {
                hrizantemasPrice = hrizantemas * 3.75;
                rosePrice = rose * 4.5;
                lalePrice = lale * 4.15;
                if (day == "Y")
                {
                    sum = (hrizantemasPrice + rosePrice + lalePrice) * 1.15;
                }
                else if (day == "N")
                {
                    sum = hrizantemasPrice + rosePrice + lalePrice;
                }
            }
            else if (season == "Winter")
            {
                hrizantemasPrice = hrizantemas * 3.75;
                rosePrice = rose * 4.5;
                lalePrice = lale * 4.15;
                if (day == "Y")
                {
                    sum = (hrizantemasPrice + rosePrice + lalePrice) * 1.15;
                }
                else if (day == "N")
                {
                    sum = hrizantemasPrice + rosePrice + lalePrice;
                }
                if (rose >= 10)
                {
                    sum = sum * 0.90;
                }
            }
            if (allflowers > 20)
            {
                Console.WriteLine($"{(sum * 0.80 + 2):f2}");
            }
            else
            {
                Console.WriteLine($"{(sum + 2):f2}");
            }
        }
    }
}
