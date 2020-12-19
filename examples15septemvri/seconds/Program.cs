using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int secondsA = int.Parse(Console.ReadLine());
            int secondsB = int.Parse(Console.ReadLine());
            int secondsC = int.Parse(Console.ReadLine());
            int minutes = (secondsA + secondsB + secondsC) / 60;
            int seconds = (secondsA + secondsB + secondsC) % 60;
            Console.WriteLine("{0}:{1:00}", minutes, seconds);

        
        }
    }
}