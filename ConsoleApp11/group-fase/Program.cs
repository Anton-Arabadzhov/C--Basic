using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group_fase
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int matchCount = int.Parse(Console.ReadLine());

            int points = 0;
            int totalGoalsScored = 0;
            int totalGoalsRecieved = 0;
            for (int gameNumber = 0; gameNumber < matchCount; gameNumber++)
            {
                int goalsScored = int.Parse(Console.ReadLine());
                int goalsRecieved = int.Parse(Console.ReadLine());

                if (goalsScored > goalsRecieved)
                {
                    points += 3;
                }
                else if (goalsScored == goalsRecieved)
                {
                    points += 1; 
                }
                
                totalGoalsScored += goalsScored;
                totalGoalsRecieved += goalsRecieved;

            }
            int goalDifference = totalGoalsScored - totalGoalsRecieved;
            if (totalGoalsScored >= totalGoalsRecieved)
            {
                Console.WriteLine($"{team} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {goalDifference}."); 
            }
            else 
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {goalDifference}.");
            }

        }
    }
}
