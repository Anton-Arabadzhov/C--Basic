using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghereography
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersOfSteps = double.Parse(Console.ReadLine());
            var dancers = double.Parse(Console.ReadLine());
            var countDays = double.Parse(Console.ReadLine());
            // when finding the percent -> use Math.Ceilling!
            var stepsPerDay = numbersOfSteps / countDays; // -> 10464 / 20 = 523,2
            var secondStep = stepsPerDay / numbersOfSteps; // -> 523,2 / 10464 = 0,05
            var percent = Math.Ceiling(secondStep * 100); // -> 0,05 * 100 = 5
            var totalPercent = percent / dancers; // -> 0,25
            // now lets if they will succeed or nah.
            if (percent <= 13) // 0,25 < 13 = true
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {totalPercent:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {totalPercent:F2}% steps to be learned per day.");
            }
        }
    }
}
