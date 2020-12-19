using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string imput = Console.ReadLine();

            if (imput == "banana" || imput=="apple" || imput=="kiwi" || imput=="cherry" || imput=="lemon" || imput=="grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (imput=="tomato" || imput=="cucumber" || imput=="pepper"|| imput=="carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
