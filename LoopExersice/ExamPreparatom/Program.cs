using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparatom
{
    class Program
    {
        static void Main(string[] args)
        {
            int failGrades = int.Parse(Console.ReadLine());

            string problem = "";
            int numberProblems = 0;
            double allGrades = 0;
            double fail = 0;

            while (true)
            {
                if (fail == failGrades)
                {
                    Console.WriteLine($"You need a break, {fail} poor grades.");
                    break;
                }
                string type = Console.ReadLine();
                if (type == "Enough")
                {
                    
                    Console.WriteLine($"Average score: {allGrades / numberProblems:f2}");
                    Console.WriteLine($"Number of problems: {numberProblems}");
                    Console.WriteLine($"Last problem: {problem}");
                    break;

                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    
                    fail++;
                }
                problem = type;
                allGrades += grade;
                numberProblems++;

            }
        }
    }
}
