using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double wigth = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double area = lenght * wigth * hight;
            percent = percent * 0.01;
            double litres = area * 0.001;

            Console.WriteLine($"{(litres * (1 - percent)):F3}");

        }
    }
}
