using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string ticketsType = Console.ReadLine();
            int peoples = int.Parse(Console.ReadLine());
            double ticketsCoast = 0;
            double moneyfortravel = 0;
            double moneyfortickets = 0;
            if (ticketsType=="VIP")
            {
                ticketsCoast = 499.99;
            }
            else
            {
                ticketsCoast = 249.99;
            }
            if (peoples >= 1 && peoples <= 4)
            {
                moneyfortravel = money * 0.75;
            }
            else if (peoples >= 5 && peoples <= 9)
            {
                moneyfortravel = money * 0.60;
            }
            else if (peoples >= 10 && peoples <= 24)
            {
                moneyfortravel = money * 0.50;
            }
            else if (peoples >= 25 && peoples <= 49)
            {
                moneyfortravel = money * 0.40;
            }
            else if (peoples >= 50)
            {
                moneyfortravel = money * 0.25;
            }
            moneyfortickets = money - moneyfortravel;

            if (moneyfortickets>=peoples*ticketsCoast)
            {
                Console.WriteLine($"Yes! You have {(moneyfortickets - (peoples * ticketsCoast)):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {((peoples * ticketsCoast) - moneyfortickets):f2} leva.");
            }        
                    
        }
    }
}
