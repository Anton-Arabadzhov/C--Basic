using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgarityCampain
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int bakers = int.Parse(Console.ReadLine());
            int cakeCounts = int.Parse(Console.ReadLine());
            int WaffleCounts = int.Parse(Console.ReadLine());
            int pancakesCounts = int.Parse(Console.ReadLine());

            double cakePrice = cakeCounts * 45;
            double wafflePrice = WaffleCounts * 5.80;
            double pancakesPrice = pancakesCounts * 3.20;

            double allfoodPrice = ((cakePrice + wafflePrice + pancakesPrice) * bakers) * days;
            double mmoneyForConsumatives = allfoodPrice / 8;
            double moneysaved = allfoodPrice - mmoneyForConsumatives;

            Console.WriteLine(moneysaved);
        }
    }
}
