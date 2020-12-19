using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasword
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            

            while (true)
            {
               string imput = Console.ReadLine();
                if (imput == password)
                {
                    
                    break;
                }
            }
            Console.WriteLine($"Welcome {userName}!");
        }
    }
}
