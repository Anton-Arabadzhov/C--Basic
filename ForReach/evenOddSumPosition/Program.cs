using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOddSumPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.Parse(Console.ReadLine());
            int maxNum = int.Parse(Console.ReadLine());

           

            for (int i = minNum; i < maxNum; i++)
                
            {
                int oddSum = 0;
                int eveSum = 0;
                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        eveSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == eveSum)
                {
                    Console.Write(i + " ");
                }
            }
            
            {

            }
        }
    }
}
