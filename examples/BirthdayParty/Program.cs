using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomRent = double.Parse(Console.ReadLine());

            double cake = roomRent * 0.20;
            double drinks = cake * 0.55;
            double animator = roomRent / 3;
            double moneyneed = roomRent + cake + drinks + animator;

            Console.WriteLine(moneyneed);
        }
    }
}
