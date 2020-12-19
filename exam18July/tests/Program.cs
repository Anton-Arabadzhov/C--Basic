using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int startnumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            int firstNum = startnumber / 1000;
            int secondNum = (startnumber / 100) % 10;
            int thirtNum = (startnumber / 10) % 10;
            int fourNum = startnumber % 10;

            int firstNumend = endNumber / 1000;
            int secondNumEnd = (endNumber / 100) % 10;
            int thirtNumEnd = (endNumber / 10) % 10;
            int fourNumEnd = endNumber % 10;

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirtNum);
            Console.WriteLine(fourNum);
            Console.WriteLine(firstNumend);
            Console.WriteLine(secondNumEnd);
            Console.WriteLine(thirtNumEnd);
            Console.WriteLine(fourNumEnd);
            
        }
    }
}
