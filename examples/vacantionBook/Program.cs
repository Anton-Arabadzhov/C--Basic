using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacantionBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double bookpages = double.Parse(Console.ReadLine());
            double pagesperHour = double.Parse(Console.ReadLine());
            double daystoRead = double.Parse(Console.ReadLine());

            double hoursforBook = bookpages / pagesperHour;
            double result = hoursforBook / daystoRead;

            Console.WriteLine(result);
        }
    }
}

