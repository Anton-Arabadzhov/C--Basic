﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_1_M.step3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
