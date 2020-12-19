using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeSide1 = int.Parse(Console.ReadLine());
            int cakeSide2 = int.Parse(Console.ReadLine());

            double cakeArea = cakeSide1 * cakeSide2;
            double cake = 0;

            while (cake < cakeArea)
            {
                string stop = Console.ReadLine();
                if (stop == "STOP")
                {
                    break;
                }
                int piece = int.Parse(stop);
                cake += piece;
            }
            if (cake > cakeArea)
            {
                double needCake = cake - cakeArea;
                Console.WriteLine($"No more cake left! You need {needCake} pieces more.");
            }
            else
            {
                double cakeLeft = cakeArea - cake;
                Console.WriteLine($"{cakeLeft} pieces are left.");
            }
        }
    }
}
