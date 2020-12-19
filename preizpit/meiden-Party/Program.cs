using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int countloveSuveniur = int.Parse(Console.ReadLine());
            int countfosilRose = int.Parse(Console.ReadLine());
            int countkeyRing = int.Parse(Console.ReadLine());
            int countpicture = int.Parse(Console.ReadLine());
            int countluckysup = int.Parse(Console.ReadLine());
            
            

            double loveSuveniur = 0.60;
            double FostilRose = 7.20;
            double keyRing = 3.60;
            double picture = 18.20;
            double luckysup = 22.00;
            

            double allCounts = countfosilRose + countkeyRing + countloveSuveniur + countluckysup + countpicture;
            double countsPrice = (countloveSuveniur * loveSuveniur) + (countfosilRose * FostilRose) + (countkeyRing * keyRing) + (countpicture * picture) + (countluckysup * luckysup);
            double promotion = countsPrice - (countsPrice * 0.35);
            double hosting = promotion - (promotion * 0.10);
            double unPromotion = countsPrice  - (countsPrice * 0.10);
            
            
            

            if (allCounts >= 25)
            {
                if (hosting >= partyPrice)
                {
                    Console.WriteLine($"Yes! {hosting - partyPrice:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {partyPrice - hosting:F2} lv needed.");
                }


            }
            if (allCounts < 25)
            {
                if (unPromotion >= partyPrice)
                {
                    Console.WriteLine($"Yes! {unPromotion - partyPrice:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {partyPrice - unPromotion:F2} lv needed.");
                }
            }
            
            
            
                
            
            


        }
    }
}
