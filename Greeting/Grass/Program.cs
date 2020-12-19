using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grass
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double finalprice = area * 7.61;
            double discount = finalprice * 0.18;
            double discountprice = finalprice - discount;

            Console.WriteLine($"The final price is: {discountprice,2} lv.");
            Console.WriteLine($"The discount is:{discount,2} lv.");



        }
    }
}