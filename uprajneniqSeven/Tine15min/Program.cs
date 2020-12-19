using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tine15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            double allminutes = minutes + 15;

            if (allminutes > 59)
            {
                hour = hour + 1;
                allminutes = allminutes - 60;
            }
            
            if (hour > 23)
            {
                hour = 0;
            }
            if (allminutes < 10)
            {
                Console.WriteLine($"{hour}:0{allminutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{allminutes}");
            }
        }
    }
}
