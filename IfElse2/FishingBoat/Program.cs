using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double totalMoney = 0.0;
            if (season == "Spring")
            {
                totalMoney = 3000;
                if (fishers <= 6)
                {
                    totalMoney = totalMoney * 0.90;
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    totalMoney = totalMoney * 0.85;
                }
                else if (fishers > 12)
                {
                    totalMoney = totalMoney * 0.75;
                }
                if (fishers % 2 == 0)
                {
                    totalMoney = totalMoney * 0.95;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                totalMoney = 4200;
                if (fishers <= 6)
                {
                    totalMoney = totalMoney * 0.90;
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    totalMoney = totalMoney * 0.85;
                }
                else if (fishers > 12)
                {
                    totalMoney = totalMoney * 0.75;
                }
                if (season == "Summer" && fishers % 2 == 0)
                {
                    totalMoney = totalMoney * 0.95;
                }
            }
            else if (season == "Autumn")
            {
                totalMoney = 4200;
                if (fishers <= 6)
                {
                    totalMoney = totalMoney * 0.90;
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    totalMoney = totalMoney * 0.85;
                }
                else if (fishers > 12)
                {
                    totalMoney = totalMoney * 0.75;
                }
            }
            else if (season == "Winter")
            {
                totalMoney = 2600;
                if (fishers <= 6)
                {
                    totalMoney = totalMoney * 0.90;
                }
                else if (fishers > 6 && fishers <= 11)
                {
                    totalMoney = totalMoney * 0.85;
                }
                else if (fishers > 12)
                {
                    totalMoney = totalMoney * 0.75;
                }
                if (fishers % 2 == 0)
                {
                    totalMoney = totalMoney * 0.95;
                }
            }
            if (totalMoney <= budget)
            {

                    Console.WriteLine($"Yes! You have {budget - totalMoney:F2} leva left.");
            }
             else
            { 
                    Console.WriteLine($"Not enough money! You need {totalMoney - budget:f2} leva.");
            }
            
            
        }
    }
}
