using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double yearpercent = double.Parse(Console.ReadLine());

            double savesYear = (money * yearpercent) / 100;
            double savesMount = savesYear / 12;
            double allsaves = period * savesMount;
            double result = money + allsaves;


            Console.WriteLine(result);

        }
    }
}
