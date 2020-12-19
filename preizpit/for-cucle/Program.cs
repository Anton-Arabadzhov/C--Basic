using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cucle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            var stars = 1;
            var spaces = n / 2;
            for (var row = 0; row < n / 2; row++)
            {

                for (var i = 0; i < spaces; i++)
                
                    Console.Write(" ");
                
                Console.Write("*");
                for (var i = 0; i < stars - 1; i++)
                
                    Console.Write(" *");
                
                Console.WriteLine();
                stars++;
                spaces--;
            }
            spaces = 1;
            stars = n / 2;
            for (var row = 0; row < n / 2; row++)
            {

                for (var i = 0; i < spaces; i++)
                
                    Console.Write(" ");
                
                Console.Write("*");
                for (var i = 0; i < stars - 1; i++)
                
                    Console.Write(" *");
                
                Console.WriteLine();
                stars--;
                spaces++;
            }
        }
    }
}
