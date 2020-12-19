using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
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

            for (int first = firstNum; first <= firstNumend; first++)
            {
                for (int two = secondNum; two <= secondNumEnd; two++)
                {
                    for (int thirt = thirtNum; thirt <= thirtNumEnd; thirt++)
                    {
                        for (int four = fourNum; four <= fourNumEnd; four++)
                        {
                            if (first % 2 != 0 && two % 2 != 0 && thirt % 2 != 0 && four % 2 != 0 )
                            {
                                Console.Write($"{first}{two}{thirt}{four} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
