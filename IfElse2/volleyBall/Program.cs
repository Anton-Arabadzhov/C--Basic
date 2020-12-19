using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            double sofiaweeks = (48 - h) * 3 / 4;
            double gamesinSofia = p * 2 / 3;
            double allGames = sofiaweeks + h + gamesinSofia;
            double vYearGames = allGames + (allGames * 0.15);

            if (leap == "leap")
            {
                Console.WriteLine(Math.Floor(vYearGames));
            }
            else if (leap == "normal")
            {
                Console.WriteLine(Math.Floor(allGames));
            }

            
        }   

    }
}
