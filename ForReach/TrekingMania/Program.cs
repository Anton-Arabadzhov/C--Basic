using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrekingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNumber = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            double allMountains = 0;

            for (int i = 1; i <= groupsNumber; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers <= 5)
                {
                    musala += numbers;
                }
                else if (numbers > 5 && numbers <= 12)
                {
                    monblan += numbers;
                }
                else if (numbers > 12 && numbers <= 25)
                {
                    kilimandjaro += numbers;
                }
                else if (numbers > 25 && numbers <= 40)
                {
                    k2 += numbers;
                }
                else
                {
                    everest += numbers;
                }
                allMountains += numbers;
            }

            double musalaPercent = (musala / allMountains) * 100;
            double monblanPercent = (monblan / allMountains) * 100;
            double kilimandjaroPercent = (kilimandjaro / allMountains) * 100;
            double k2Percent = (k2 / allMountains) * 100;
            double everestPercent = (everest / allMountains) * 100;

            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{monblanPercent:f2}%");
            Console.WriteLine($"{kilimandjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}
