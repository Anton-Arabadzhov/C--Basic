using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoptedDog
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodKg = int.Parse(Console.ReadLine());

            double foodInGrams = foodKg * 1000;
            int foodEaten = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Adopted")
                {
                    break;
                }

                int foodPerEat = int.Parse(input);
                foodEaten += foodPerEat;

            }
            double finalResult = foodInGrams - foodEaten;
            if (foodInGrams >= foodEaten)
            {
                Console.WriteLine($"Food is enough! Leftovers: {Math.Abs(finalResult)} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(finalResult)} grams more.");
            }
        }
    }
}
