using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int zumbiuli = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnoliasPrice = 3.25;
            double zumbiuliPrice = 4.00;
            double rosePrice = 3.50;
            double cactisPrice = 8.00;

            double sumFlowers = magnolias * magnoliasPrice + zumbiuli * zumbiuliPrice + rose * rosePrice + cactus * cactisPrice;
            double priceWhitoutPercent = sumFlowers * 0.95;
            if (giftPrice > priceWhitoutPercent)
            {
                double moneyneed = giftPrice - priceWhitoutPercent;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyneed)} leva.");
            }
            else
            {
                double moneyleft = priceWhitoutPercent - giftPrice;
                Console.WriteLine($"She is left with {Math.Truncate(moneyleft)} leva.");
            }
        }
    }
}
