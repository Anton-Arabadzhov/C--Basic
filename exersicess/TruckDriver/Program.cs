using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMount = double.Parse(Console.ReadLine());

            double moneyperkm = 0;
            double selary = 0;

            if (kmPerMount <= 5000 && season == "Spring")
            {
                moneyperkm = kmPerMount * 0.75;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount <= 5000 && season == "Autumn")
            {
                moneyperkm = kmPerMount * 0.75;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount > 5000 && kmPerMount <= 10000 && season == "Spring" || season == "Autumn")
            {
                moneyperkm = kmPerMount * 0.95;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount > 10000 && kmPerMount <= 20000 && season == "Spring" || season == "Autumn")
            {
                moneyperkm = kmPerMount * 1.45;
                selary = (moneyperkm * 4) * 0.90;
            }

            if (kmPerMount <= 5000 && season == "Summer")
            {
                moneyperkm = kmPerMount * 0.90;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount > 5000 && kmPerMount <= 10000 && season == "Summer")
            {
                moneyperkm = kmPerMount * 1.10;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount > 10000 && kmPerMount <= 20000 && season == "Summer")
            {
                moneyperkm = kmPerMount * 1.45;
                selary = (moneyperkm * 4) * 0.90;
            }
            if (kmPerMount <= 5000 && season == "Winter")
            {
                moneyperkm = kmPerMount * 1.05;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount > 5000 && kmPerMount <= 10000 && season == "Winter")
            {
                moneyperkm = kmPerMount * 1.25;
                selary = (moneyperkm * 4) * 0.90;
            }
            else if (kmPerMount > 10000 && kmPerMount <= 20000 && season == "Winter")
            {
                moneyperkm = kmPerMount * 1.45;
                selary = (moneyperkm * 4) * 0.90;
            }
            Console.WriteLine($"{selary:f2}");
        }
    }
}
