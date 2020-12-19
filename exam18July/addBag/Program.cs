using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addBag
{
    class Program
    {
        static void Main(string[] args)
        {
            double suitcase20Kg = double.Parse(Console.ReadLine());
            double suitCaseKg = double.Parse(Console.ReadLine());
            int dayToTravel = int.Parse(Console.ReadLine());
            int suitcasesCounts = int.Parse(Console.ReadLine());

            double sum = 0;

            if (suitCaseKg < 10)
            {
                sum += suitcase20Kg * 0.20;
                if (dayToTravel < 7)
                {
                    sum = sum * 1.4;
                }
                else if (dayToTravel >= 7 && dayToTravel <= 30)
                {
                    sum += sum * 0.15;
                }
                else
                {
                    sum += sum * 0.10;
                }
            }
            else if (suitCaseKg >= 10 && suitCaseKg <= 20)
            {
                sum += suitcase20Kg / 2;
                if (dayToTravel < 7)
                {
                    sum = sum * 1.4;
                }
                else if (dayToTravel >= 7 && dayToTravel <= 30)
                {
                    sum += sum * 0.15;
                }
                else
                {
                    sum += sum * 0.10;
                }
            }
            else
            {
                sum += suitcase20Kg;
                if (dayToTravel < 7)
                {
                    sum = sum * 1.4;
                }
                else if (dayToTravel >= 7 && dayToTravel <= 30)
                {
                    sum += sum * 0.15;
                }
                else
                {
                    sum += sum * 0.10;
                }
            }
            double finalPrice = sum * suitcasesCounts;
            Console.WriteLine($"The total price of bags is: {finalPrice:f2} lv.");
        }
    }
}
