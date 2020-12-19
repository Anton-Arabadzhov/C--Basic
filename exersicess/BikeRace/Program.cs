using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int Seniors = int.Parse(Console.ReadLine());
            string typeRice = Console.ReadLine();

            double moneyJunior = 0;
            double moneySeniors = 0;
            double allBikers = juniors + Seniors;
            double sum = 0;


            if (typeRice == "trail")
            {
                moneyJunior = juniors * 5.50;
                moneySeniors = Seniors * 7;
                sum = (moneyJunior + moneySeniors) * 0.95;
            }
            else if (typeRice == "cross-country")
            {
                moneyJunior = juniors * 8;
                moneySeniors = Seniors * 9.50;
                sum = (moneyJunior + moneySeniors) * 0.95;
                if (allBikers >= 50)
                {
                    sum = sum * 0.75;
                }
            }
            else if (typeRice == "downhill")
            {
                moneyJunior = juniors * 12.25;
                moneySeniors = Seniors * 13.75;
                sum = (moneyJunior + moneySeniors) * 0.95;
            }
            else if (typeRice == "road")
            {
                moneyJunior = juniors * 20;
                moneySeniors = Seniors * 21.50;
                sum = (moneyJunior + moneySeniors) * 0.95;
            }
                
            
            Console.WriteLine($"{sum:f2}");
        }
    }
}
