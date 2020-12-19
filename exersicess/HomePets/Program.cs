using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double thurtleFood = double.Parse(Console.ReadLine());


            double dogFoodNeed = days * dogFood;
            double catFoodNeed = days * catFood;
            double thurtleFoodNeed = days * thurtleFood;
            double thurtleFoodKg = thurtleFoodNeed / 1000;
            double allFoodNeed = dogFoodNeed + catFoodNeed + thurtleFoodKg;
            
            

            if (food >= allFoodNeed)
            {
                allFoodNeed = food - allFoodNeed;
                Console.WriteLine($"{Math.Truncate(allFoodNeed)} kilos of food left.");
            }
            else
            {
                allFoodNeed = allFoodNeed - food;
                Console.WriteLine($"{Math.Ceiling(allFoodNeed)} more kilos of food are needed.");
            }
        }
    }
}
