using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int walkTimes = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            double totalCalories = walkTimes * minutesWalk * 5;
            double caloriesNeeded = caloriesPerDay / 2;
            if (totalCalories >= caloriesNeeded)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {totalCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {totalCalories}.");
            }
        }
    }
}
