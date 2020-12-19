using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string student = Console.ReadLine();
            int currentClass = 1;
            double allGrade = 0;
            int count = 0;
            while (currentClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    ++count;
                    if (count >1)
                    {
                        Console.WriteLine($"{student} has been excluded at {currentClass} grade");return;

                    }

                }
                else if (grade >=4)
                {
                    allGrade += grade;
                    currentClass++;
                }
            }
            double average = allGrade / 12.0;
            Console.WriteLine($"{student} graduated. Average grade: {average:F2}");
        }
    }
}
