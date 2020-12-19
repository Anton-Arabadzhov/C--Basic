using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentCristmass
{
    class Program
    {
        static void Main(string[] args)
        {
            int sportsDays = int.Parse(Console.ReadLine());

            double sum = 0;
            int number = 0;
            double alldaysWin = 0;
            double alldayLose = 0;
            while (number < sportsDays)
            {
                
                
                double sumperDay = 0;
                double wingames = 0;
                double loseGames = 0;
                

                while (true)
                {
                    string sport = Console.ReadLine();
                    if (sport == "Finish")
                    {
                        if (wingames > loseGames)
                        {
                            sumperDay *= 1.1;
                        }
                        sum += sumperDay;
                        sumperDay = 0;
                        wingames = 0;
                        loseGames = 0;
                        number++;
                        break;
                    }
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        sumperDay += 20;
                        wingames++;
                        alldaysWin++;
                    }
                    else if (result == "lose")
                    {
                        loseGames++;
                        alldayLose++;
                    }
                    
                    
                }
                
                if (sportsDays == number)
                {
                    break;
                }

            }
            if (alldaysWin > alldayLose)
            {
                sum *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: { sum:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {sum:f2}");
            }
            
        }
    }
}
