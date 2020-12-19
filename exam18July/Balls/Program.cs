using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());

            int points = 0;

            int redBalls = 0;
            int blackBalls = 0;
            int yellowBalls = 0;
            int orangeBalls = 0;
            int whiteBalls = 0;

            int otherBalls = 0;
            int devidet2 = 0;

            for (int i = 1; i <= balls; i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    redBalls++;
                    points += 5;
                }
                else if (color == "orange")
                {
                    orangeBalls++;
                    points += 10;
                }
                else if (color == "yellow")
                {
                    yellowBalls++;
                    points += 15;
                }
                else if (color == "white")
                {
                    whiteBalls++;
                    points += 20;
                }
                else if (color == "black")
                {
                    blackBalls++;
                    points /= 2;
                    devidet2++;
                }
                else
                {
                    otherBalls++;
                }

            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Points from red balls: {redBalls}");
            Console.WriteLine($"Points from orange balls: {orangeBalls}");
            Console.WriteLine($"Points from yellow balls: {yellowBalls}");
            Console.WriteLine($"Points from white balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherBalls}");
            Console.WriteLine($"Divides from black balls: {devidet2}");
        }
    }
}
