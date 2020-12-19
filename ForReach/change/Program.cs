using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoin = int.Parse(Console.ReadLine());
            double chineeseuan = double.Parse(Console.ReadLine());
            double comisions = double.Parse(Console.ReadLine());

            double leva = bitCoin * 1168;
            double uan = (1.76 * 0.15) * chineeseuan;
            
            double totalmoney= (leva + uan) / 1.95;
            double percent = (double)comisions / 100;
            double totalDiscount = totalmoney * percent;
            double finalResult = totalmoney - totalDiscount;


            Console.WriteLine($"{finalResult:f2}");
                
        }
    }
}
