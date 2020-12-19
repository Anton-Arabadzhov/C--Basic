using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int selary = int.Parse(Console.ReadLine());


            double leftSelary = selary;

            for (int i = 0; i < n; i++)
            {
                
                string tab = Console.ReadLine();

                if (tab == "Facebook")
                {
                    leftSelary -= 150;
                }
                if (tab == "Instagram")
                {
                    leftSelary -= 100;
                }
                if (tab == "Reddit")
                {
                    leftSelary -= 50;
                }
                if (leftSelary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (leftSelary > 0)
            {
                Console.WriteLine(leftSelary);
            }
        }
    }
}
