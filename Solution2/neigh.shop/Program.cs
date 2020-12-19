using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neigh.shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string Town = Console.ReadLine();
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double finalprice = 0;

            if (Town == "Sofia")
            {
                if (product == "coffee")
                {
                    finalprice = quantity * 0.50;
                    Console.WriteLine(finalprice);
                }
                else if (product == "water")
                {
                    finalprice = quantity * 0.80;
                    Console.WriteLine(finalprice);
                }
                else if (product == "beer")
                {
                    finalprice = quantity * 1.20;
                    Console.WriteLine(finalprice);
                }
                else if (product == "sweets")
                {
                    finalprice = quantity * 1.45;
                    Console.WriteLine(finalprice);
                }
                else if (product == "peanuts")
                {
                    finalprice = quantity * 1.60;
                    Console.WriteLine(finalprice);
                }

            }
            else if (Town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    finalprice = quantity * 0.40;
                    Console.WriteLine(finalprice);
                }
                else if (product == "water")
                {
                    finalprice = quantity * 0.70;
                    Console.WriteLine(finalprice);
                }
                else if (product == "beer")
                {
                    finalprice = quantity * 1.15;
                    Console.WriteLine(finalprice);
                }
                else if (product == "sweets")
                {
                    finalprice = quantity * 1.30;
                    Console.WriteLine(finalprice);
                }
                else if (product == "peanuts")
                {
                    finalprice = quantity * 1.50;
                    Console.WriteLine(finalprice);
                }
            }
            else if (Town == "Varna")
            {
                if (product == "coffee")
                {
                    finalprice = quantity * 0.45;
                    Console.WriteLine(finalprice);
                }
                else if (product == "water")
                {
                    finalprice = quantity * 0.70;
                    Console.WriteLine(finalprice);
                }
                else if (product == "beer")
                {
                    finalprice = quantity * 1.10;
                    Console.WriteLine(finalprice);
                }
                else if (product == "sweets")
                {
                    finalprice = quantity * 1.35;
                    Console.WriteLine(finalprice);
                }
                else if (product == "peanuts")
                {
                    finalprice = quantity * 1.55;
                    Console.WriteLine(finalprice);
                }
            }
        }
    }
}
