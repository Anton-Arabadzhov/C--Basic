using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string Internet = Console.ReadLine();
            int moutsPay = int.Parse(Console.ReadLine());

            double contractPrice = 0;

            if (contractType == "Small")
            {
                if (contractPeriod == "one")
                {
                    contractPrice = 9.98;
                }
                else if (contractPeriod == "two")
                {
                    contractPrice = 8.58;
                }
                if (Internet == "yes")
                {
                    contractPrice += 5.50;
                }
            }
            else if (contractType == "Middle")
            {
                if (contractPeriod == "one")
                {
                    contractPrice = 18.99;
                }
                else if (contractPeriod == "two")
                {
                    contractPrice = 17.09;
                }
                if (Internet == "yes")
                {
                    contractPrice += 4.35;
                }
            }
            else if (contractType == "Large")
            {
                if (contractPeriod == "one")
                {
                    contractPrice = 25.98;
                }
                else if (contractPeriod == "two")
                {
                    contractPrice = 23.59;

                }
                if (Internet == "yes")
                {
                    contractPrice += 4.35;
                }
            }
            else if (contractType == "ExtraLarge")
            {
                if (contractPeriod == "one")
                {
                    contractPrice = 35.99;
                }
                else if (contractPeriod == "two")
                {
                    contractPrice = 31.79;
                }
                if (Internet == "yes")
                {
                    contractPrice += 3.85;
                }
            }
            if (contractPeriod == "two")
            {
                contractPrice *= 0.9625;
            }
            double finalPrice = contractPrice * moutsPay;
            Console.WriteLine($"{finalPrice:f2} lv.");

        }
    }
}
