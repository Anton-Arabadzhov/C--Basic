using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int max = int.MinValue;
            string maxM = "";
            string minM = "";
            double rating = 0;

            for (int i = 0; i <= movies; i++)
           
            {
                string monieName = Console.ReadLine();
                double score = double.Parse(Console.ReadLine());
                rating += score;
                if (score > max)
                {
                    score = max;
                    monieName = maxM;
                }
                else if (score < min)
                {
                    score = min;
                    monieName = minM;
                }
            }
            Console.WriteLine(maxM);
            Console.WriteLine($"{max:f1}");
            Console.WriteLine();
        }
    }
}
