using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int studendsCounts = 0;
            int standardCounts = 0;
            int kidsCounts = 0;
            int movietickets = 0;
            double ticketsCount = 0;
            while (true)
            {
                string movie = Console.ReadLine();

                if (movie == "Finish")
                {
                    break;
                }
                int ticketRoom = int.Parse(Console.ReadLine());
                
                while (movietickets < ticketRoom)
                {
                    string students = Console.ReadLine();
                    if (students == "End")
                    {
                        break;
                    }
                    if (students == "student")
                    {
                        studendsCounts++;
                    }
                    else if (students == "standard")
                    {
                        standardCounts++;
                    }
                    else if (students == "kid")
                    {
                        kidsCounts++;
                    }
                    ticketsCount++;
                    movietickets++;
                }
                double totalRoom = (movietickets * 100.0) / ticketRoom;
                
                Console.WriteLine($"{movie} - {totalRoom:f2}% full.");
                movietickets = 0;

            }
            double standardPercentTickets = (standardCounts * 100.0) / ticketsCount;
            double studentPercentTickets = (studendsCounts * 100.0) / ticketsCount;
            double kidsPercentTickets = (kidsCounts * 100.0) / ticketsCount;
            Console.WriteLine($"Total tickets: {ticketsCount}");
            Console.WriteLine($"{studentPercentTickets:f2}% student tickets.");
            Console.WriteLine($"{standardPercentTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidsPercentTickets:f2}% kids tickets.");
            
        }
    }
}
