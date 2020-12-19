using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestBook = Console.ReadLine();

            double bookCounter = 0;

            while (true)
            {
                string book = Console.ReadLine();
                if (book == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {bookCounter} books.");
                    break;
                }
                if (book == bestBook)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    break;
                }
                bookCounter++;
            }
            
        }
    }
}
