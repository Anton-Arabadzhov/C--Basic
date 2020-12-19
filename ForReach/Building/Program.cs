using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int levels = int.Parse(Console.ReadLine());
                int rooms = int.Parse(Console.ReadLine());

                for (int f = levels; f >= 1; f--)
                {
                    for (int g = 0; g < rooms; g++)
                    {
                        if (f == levels)
                        {
                            Console.Write($"L{f}{g} ");
                        }
                        else if (f % 2 == 0 && f != levels)
                        {
                            Console.Write($"O{f}{g} ");
                        }
                        else
                        {
                            Console.Write($"A{f}{g} ");
                        }
                    }
                    Console.WriteLine();
                }

            
        }
    }
}
