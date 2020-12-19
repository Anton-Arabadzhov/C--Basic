using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double sum = 0;

            if (sport == "Gym")
            {
                if (gender == 'm')
                {
                    sum += 42;
                }
                else if (gender == 'f')
                {
                    sum += 35;
                }
            }
            else if (sport == "Boxing")
            {
                if (gender == 'm')
                {
                    sum += 41;
                }
                else if (gender == 'f')
                {
                    sum += 37;
                }
            }
            else if (sport == "Yoga")
            {
                if (gender == 'm')
                {
                    sum += 45;
                }
                else if (gender == 'f')
                {
                    sum += 42;
                }
            }
            else if (sport == "Zumba")
            {
                if (gender == 'm')
                {
                    sum += 34;
                }
                else if (gender == 'f')
                {
                    sum += 31;
                }
            }
            else if (sport == "Dances")
            {
                if (gender == 'm')
                {
                    sum += 51;
                }
                else if (gender == 'f')
                {
                    sum += 53;
                }
            }
            else if (sport == "Pilates")
            {
                if (gender == 'm')
                {
                    sum += 39;
                }
                else if (gender == 'f')
                {
                    sum += 37;
                }
            }
            if (years <= 19)
            {
                sum = sum * 0.80;
            }
            if (moneyHave >= sum)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${sum - moneyHave:f2} more.");
            }
        }
    }
}
