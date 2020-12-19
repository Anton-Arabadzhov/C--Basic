using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeed = double.Parse(Console.ReadLine());
            double moneyHave = double.Parse(Console.ReadLine());

            double spendCounte = 0;
            double daysSave = 0;
            

            while (moneyHave < moneyNeed && spendCounte < 5)
            {
                string action = Console.ReadLine();
                double moneyAction = double.Parse(Console.ReadLine());
                daysSave++;
                if (action == "save")
                {
                    moneyHave += moneyAction;
                    spendCounte = 0;
                }
                else if (action == "spend")
                {
                    moneyHave -= moneyAction;
                    spendCounte++;
                    if (moneyHave < 0)
                    {
                        moneyHave = 0;
                    }
                }
                if (spendCounte == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine(spendCounte);
                    
                }
                if (moneyHave >= moneyNeed)
                {
                    Console.WriteLine($"You saved the money for {daysSave} days.");
                }

            }
            
        }
    }
}
