using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YardGreetings
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaToGrass = double.Parse(Console.ReadLine());

            double price = areaToGrass * 7.61;
            double discount = price * 0.18;
            double finalprice = price - discount;

            Console.WriteLine($"The final price is: {finalprice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
