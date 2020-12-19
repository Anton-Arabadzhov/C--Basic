using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNumber = 0;
            int nonprimeNumber = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int number = int.Parse((input));
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= number - 1; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        
                    }
                    if (isPrime)
                    {
                        primeNumber += number;
                    }
                    else
                    {
                        nonprimeNumber += number;
                    }
                }
                
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeNumber}");
        }
    }
}
