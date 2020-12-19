using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensPack = int.Parse(Console.ReadLine());
            int markersPack = int.Parse(Console.ReadLine());
            double cleanChemical = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double penPrice = pensPack * 5.80;
            double markersPrice = markersPack * 7.20;
            double chemicalPrice = cleanChemical * 1.20;

            double moneyNeed = penPrice + markersPrice + chemicalPrice;
            double percenDiscount = moneyNeed * (percent / 100.0);
            double totalSum = moneyNeed - percenDiscount;

            Console.WriteLine($"{totalSum:f3}");

        }
    }
}
