using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogfood = int.Parse(Console.ReadLine());
            int otherfood = int.Parse(Console.ReadLine());
            double alldogfood = dogfood * 2.50;
            double allotherfood = otherfood * 4;
            Console.WriteLine($"{alldogfood + allotherfood} lv.");
        }
    }
}
