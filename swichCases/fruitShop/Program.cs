using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double totalprice = 0.0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    totalprice = quantity * 2.50;
                }
                else if (product == "apple")
                {
                    totalprice = quantity * 1.20;
                }
                else if (product == "orange")
                {
                    totalprice = quantity * 0.85;
                }
                else if (product == "grapefruit")
                {
                    totalprice = quantity * 1.45;
                }
                else if (product == "kiwi")
                {
                    totalprice = quantity * 2.70;
                }
                else if (product == "pineapple")
                {
                    totalprice = quantity * 5.50;
                }
                else if (product == "grapes")
                {
                    totalprice = quantity * 3.85;
                }
                
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    totalprice = quantity * 2.70;
                }
                else if (product == "apple")
                {
                    totalprice = quantity * 1.25;
                }
                else if (product == "orange")
                {
                    totalprice = quantity * 0.90;
                }
                else if (product == "grapefruit")
                {
                    totalprice = quantity * 1.60;
                }
                else if (product == "kiwi")
                {
                    totalprice = quantity * 3.00;
                }
                else if (product == "pineapple")
                {
                    totalprice = quantity * 5.60;
                }
                else if (product == "grapes")
                {
                    totalprice = quantity * 4.20;
                }
                
            }
            if (totalprice > 0)
            {
                Console.WriteLine($"{totalprice:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
