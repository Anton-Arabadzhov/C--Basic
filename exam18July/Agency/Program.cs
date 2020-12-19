using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int standartTickets = int.Parse(Console.ReadLine());
            int kidsTickets = int.Parse(Console.ReadLine());
            double netPriceTicket = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());

            double kitsPriceTicket = netPriceTicket * 0.30;
            double finalStandartTickets = standartTickets * (netPriceTicket + serviceTax);
            double FinalKidsTickets = kidsTickets * (kitsPriceTicket + serviceTax);
            double profit = (finalStandartTickets + FinalKidsTickets) * 0.20;

            Console.WriteLine($"The profit of your agency from {company} tickets is {profit:f2} lv.");
        }
    }
}
