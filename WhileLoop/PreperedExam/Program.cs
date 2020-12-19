using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreperedExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedExamsCount = 0;
            double gradeSum = 0;
            string lastProblem = "";
            bool isFailed = true;

            while (failedTimes < failedThreshold)
            {
                string problemName = Console.ReadLine();
                if ("Enough" == problemName)
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradeSum += grade;
                solvedExamsCount++;
                lastProblem = problemName;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum / solvedExamsCount:f2}");
                Console.WriteLine($"Number of problems: {solvedExamsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
