using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxgoal = 0;
            string futbalPlayer = "";

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                int goals = int.Parse(Console.ReadLine());
                if (goals > maxgoal)
                {
                    maxgoal = goals;
                    futbalPlayer = name;
                }
                if (goals >= 10)
                {
                    maxgoal = goals;
                    futbalPlayer = name;
                    break;
                }
            }
            if (maxgoal >= 3)
            {
                Console.WriteLine($"{futbalPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxgoal} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{futbalPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxgoal} goals.");
                
            }
        }
    }
}
