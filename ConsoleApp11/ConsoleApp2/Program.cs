using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int combination = int.Parse(Console.ReadLine());

            int currentCombination = 0;
            bool isCombination = false;
            for (char firstSymbol = 'B'; firstSymbol <= 'L'; firstSymbol++)
            {
                for (char secondSymbol = 'f'; secondSymbol >= 'a'; secondSymbol--)
                {
                    for (char thirdSymbol = 'A'; thirdSymbol <= 'C'; thirdSymbol++)
                    {
                        for (int fourthSymbol = 1; fourthSymbol <= 10; fourthSymbol++)
                        {
                            for (int fifthSymbol = 10; fifthSymbol >= 1; fifthSymbol--)
                            {
                                if (firstSymbol % 2 == 0)
                                {
                                    currentCombination++;
                                }
                                if (currentCombination == combination)
                                {
                                    Console.WriteLine($"Ticket combination: {firstSymbol}{secondSymbol}{thirdSymbol}{fourthSymbol}{fifthSymbol}");
                                    int prize = firstSymbol + secondSymbol + thirdSymbol + fourthSymbol + fifthSymbol;
                                    Console.WriteLine($"Prize: {prize} lv.");
                                    isCombination = true;
                                    break;
                                }
                            }

                        }

                    }

                }

            }
        }
    }
}
