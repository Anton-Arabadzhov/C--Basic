using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduated
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            int totalFail = 0;
            double total = 0; 

            while (grade <= 12)
            {
                double rating = double.Parse(Console.ReadLine());

                if (rating >= 4)
                {
                    total += rating;
                    grade++;
                }
                else
                {
                    totalFail++;
                    if (totalFail == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }
                }
            }
            if (grade == 13)
            {
                double average = total / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
            
        }
    }
}
