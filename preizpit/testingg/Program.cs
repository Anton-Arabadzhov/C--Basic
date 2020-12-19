using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingg
{
    class Program
    {
        static void Main(string[] args)
        {
            // coocie factory
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            bool eggs = false;
            bool flour = false;
            bool sugar = false;

            for (int i = 1; i <= n; i++)
            {
                while (true)
                {
                    input = Console.ReadLine();
                    if (input == "eggs")
                    {
                        eggs = true;
                    }
                    else if (input == "flour")
                    {
                        flour = true;
                    }
                    else if (input == "sugar")
                    {
                        sugar = true;
                    }
                    if (input == "Bake!")
                    {
                        if (eggs && flour && sugar)
                        {
                            Console.WriteLine($"Baking batch number {i}...");
                            eggs = false;
                            flour = false;
                            sugar = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                }
            }

        }
        
    }
}
