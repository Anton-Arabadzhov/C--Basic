using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.sport
{
    class Program
    {
        static void Main(string[] args)
        {
            
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());
                var third = int.Parse(Console.ReadLine());

                var secondsSum = first + second + third;
                var minutes = secondsSum / 60;
                var seconds = secondsSum % 60;

                Console.WriteLine("{0:0}:{1:00}", minutes, seconds);
            
        }
    }
}
