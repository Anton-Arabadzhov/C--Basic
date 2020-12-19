using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string DayNight = Console.ReadLine();
            double sum = 0;

            if (DayNight == "day")
            {
                if (n < 20)
                {
                    sum = 0.70 + n * 0.79;
                }
                else if (n >= 20 && n < 100)
                {
                    sum = n * 0.09;
                }
                else if (n >= 100)
                {
                    sum = n * 0.06;
                }
            }
            else if (DayNight == "night")
            {
                if (n < 20)
                {
                    sum = 0.70 + n * 0.90;
                }
                else if (n >= 20 && n < 100)
                {
                    sum = n * 0.09;
                }
                else if (n >= 100)
                {
                    sum = n * 0.06;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
