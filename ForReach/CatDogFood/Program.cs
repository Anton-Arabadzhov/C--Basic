using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDogFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodHave = double.Parse(Console.ReadLine());

            int dogFoodSum = 0;
            int catFoodSum = 0;
            
            double biscuits = 0;
            for (int i = 1; i <= days; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                dogFoodSum += dogFood;
                catFoodSum += catFood;
                if (i % 3 == 0)
                {
                    biscuits += ((dogFood + catFood) * 0.10);
                }
            }
            double dogCatFoodEaten = dogFoodSum + catFoodSum;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
            Console.WriteLine($"{dogCatFoodEaten / foodHave * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFoodSum / dogCatFoodEaten * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{catFoodSum / dogCatFoodEaten * 100:f2}% eaten from the cat.");
        }
    }
}
