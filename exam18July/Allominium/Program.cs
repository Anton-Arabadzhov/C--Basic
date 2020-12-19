using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allominium
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
            string type = (Console.ReadLine());
            
            string delivery = Console.ReadLine();

            double sum = 0;

            if (type == "90X130")
            {
                sum = counts * 110;


                if (counts > 30 && counts <= 60)
                {
                    sum -= sum * 0.05;
                }
                else if (counts > 60)
                {
                    sum -= sum * 0.08;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
            }
            else if (Type == "100X150")
            {
                sum = counts * 140;

                if (counts > 40 && counts <= 80)
                {
                    sum -= sum * 0.06;
                }
                else if (counts > 80)
                {
                    sum -= sum * 0.10;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
            }
            else if (Type == "130X180")
            {
                sum = counts * 190;

                if (counts > 20 && counts <= 50)
                {
                    sum -= sum * 0.07;
                }
                else if (counts > 50)
                {
                    sum -= sum * 0.12;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
            }
            else if (Type == "200X300")
            {
                sum = counts * 250;

                if (counts > 25 && counts <= 50)
                {
                    sum -= sum * 0.09;
                }
                else if (counts > 50)
                {
                    sum -= sum * 0.14;
                }
                if (delivery == "With delivery")
                {
                    sum += 60;
                }
            }
            
            
            if (counts >= 100)
            {
                sum -= sum * 0.04;
            }
            if (counts <= 10)
            {
                Console.WriteLine($"Invalid order");
            }
            else
            {
                Console.WriteLine($"{sum:F2} BGN");
            }

        }
    }
}
