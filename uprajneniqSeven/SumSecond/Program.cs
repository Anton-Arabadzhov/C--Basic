using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstwin = int.Parse(Console.ReadLine());
            int secondWin = int.Parse(Console.ReadLine());
            int thurthWin = int.Parse(Console.ReadLine());

            int time = firstwin + secondWin + thurthWin;
            int minutes = time / 60;
            int seconds = time % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            
        }
    }
}
