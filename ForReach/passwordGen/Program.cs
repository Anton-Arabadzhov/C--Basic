using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int firstDigit = 1; firstDigit < startNum; firstDigit++)
            {
                for (int secontDigit = 1; secontDigit < startNum; secontDigit++)
                {
                    for (char firstSingh = 'a'; firstSingh < 'a' + endNum; firstSingh++)
                    {
                        for (char secondSingh = 'a'; secondSingh < 'a' + endNum; secondSingh++)
                        {
                            for (int last = 1; last <= startNum; last++)
                            {
                                if (last > firstDigit && last > secontDigit)
                                {
                                    Console.Write($"{firstDigit}{secontDigit}{firstSingh}{secondSingh}{last} ");
                                }
                               
                            }
                        }
                    }
                }
            }
        }
    }
}
