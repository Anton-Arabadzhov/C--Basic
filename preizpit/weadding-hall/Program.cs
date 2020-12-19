using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weadding_hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double barSize = double.Parse(Console.ReadLine());

            double room = side1 * side2;
            double barArea = barSize * barSize;
            double dancingArea = room * 0.19;
            double guestArea = room - barArea - dancingArea;
            double numberGuests = guestArea / 3.2;

            Console.WriteLine(Math.Ceiling(numberGuests));

        }
    }
}
