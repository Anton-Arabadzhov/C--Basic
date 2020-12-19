using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();
            int ppl = int.Parse(Console.ReadLine());

            
            double moneyForTransport = 0;
            double ticketsPrice = 0;
            

            if (ticket == "VIP")
            {
                ticketsPrice = ppl * 499.99;
                if (ppl >= 1 && ppl <=4)
                {
                    moneyForTransport = budget * 0.75;
                }
                else if (ppl >= 5 && ppl <= 9)
                {
                    moneyForTransport = budget * 0.60;
                }
                else if (ppl >= 10 && ppl <= 24)
                {
                    moneyForTransport = budget * 0.50;
                }
                else if (ppl >= 25 && ppl <= 49)
                {
                    moneyForTransport = budget * 0.40;
                }
                else
                {
                    moneyForTransport = budget * 0.25;
                }
            }
            else if (ticket == "Normal")
            {
                ticketsPrice = ppl * 249.99;
                if (ppl >= 1 && ppl <= 4)
                {
                    moneyForTransport = budget * 0.75;
                }
                else if (ppl >= 5 && ppl <= 9)
                {
                    moneyForTransport = budget * 0.60;
                }
                else if (ppl >= 10 && ppl <= 24)
                {
                    moneyForTransport = budget * 0.50;
                }
                else if (ppl >= 25 && ppl <= 49)
                {
                    moneyForTransport = budget * 0.40;
                }
                else
                {
                    moneyForTransport = budget * 0.25;
                }
            }
            double moneyNeed = ticketsPrice + moneyForTransport;
            if (budget > moneyNeed)
            {
                Console.WriteLine($"Yes! You have {(budget - moneyNeed):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(moneyNeed - budget):f2} leva.");
            }
        }
    }
}
