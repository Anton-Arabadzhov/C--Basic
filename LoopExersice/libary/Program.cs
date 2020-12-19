using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libary
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int bookCounter = 0;
            bool isBookFound = false;

            string nextbook = Console.ReadLine();
            while (nextbook != "No More Books")
            {
                if (nextbook == book)
                {
                    isBookFound = true;
                    break;
                }
                bookCounter++;
                nextbook = Console.ReadLine();

            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }
        }
    }
}
