using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double gradeResultAll = 0;
            int counter = 0;
            while (true)
            {
                string type = Console.ReadLine();
                double gradeResult = 0;


                if (type == "Finish")
                {
                    break;
                }
                else
                { 
                for (int i = 0; i < number; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeResult += grade;
                    gradeResultAll += grade;
                    counter++;
                }
                Console.WriteLine($"{type} - {gradeResult / number:f2}.");
                }
            }

            Console.WriteLine($"Student's final assessment is {gradeResultAll / counter:f2}.");
            
        }
    }
}
