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

            double gradeSum = 0;
            int gradeCounts = 0;
            int underGradeCounts = 0;

            while (gradeCounts < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    underGradeCounts++;
                }
                if (underGradeCounts >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {gradeCounts} grade");
                    break;
                }
                gradeSum += grade;
                gradeCounts++;
               

            }
            if (gradeCounts == 12)
            {
                double sum = gradeSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {sum:f2}");
            }
        }
    }
}
