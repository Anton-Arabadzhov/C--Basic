using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            int ppl = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double moneySleep = 0;
            double allNiths = 0;
            double finalsum = 0;

            if (season == "Winter" && gender == "boys")
            {
                moneySleep = 9.60;
                allNiths = ppl * moneySleep * nights;
                sport = "Judo";
            }
            else if (season == "Winter" && gender == "mixed")
            {
                moneySleep = 10;
                allNiths = ppl * moneySleep * nights;
                sport = "Ski";
            }
            else if (season == "Winter" && gender == "girls")
            {
                moneySleep = 9.60;
                allNiths = ppl * moneySleep * nights;
                sport = "Gymnastics";
            }
            if (season == "Summer" && gender == "boys")
            {
                moneySleep = 15;
                allNiths = ppl * moneySleep * nights;
                sport = "Football";
            }
            else if (season == "Summer" && gender == "mixed")
            {
                moneySleep = 20;
                allNiths = ppl * moneySleep * nights;
                sport = "Swimming";
            }
            else if (season == "Summer" && gender == "girls")
            {
                moneySleep = 15;
                allNiths = ppl * moneySleep * nights;
                sport = "Volleyball";
            }
            if (season == "Spring" && gender == "boys")
            {
                moneySleep = 7.2;
                allNiths = ppl * moneySleep * nights;
                sport = "Tennis";
            }
            else if (season == "Spring" && gender == "mixed")
            {
                moneySleep = 9.50;
                allNiths = ppl * moneySleep * nights;
                sport = "Cycling";
            }
            else if (season == "Spring" && gender == "girls")
            {
                moneySleep = 7.20;
                allNiths = ppl * moneySleep * nights;
                sport = "Athletics";
            }
            if (ppl >= 50)
            {
                finalsum = allNiths / 2;
            }
            else if (ppl < 50 && ppl >= 20)
            {
                finalsum = allNiths * 0.85;
            }
            else if (ppl < 20 && ppl >= 10)
            {
                finalsum = allNiths * 0.95;
            }
            else
            {
                finalsum = allNiths;
            }
            Console.WriteLine($"{sport} {finalsum:f2} lv.");
        }
    }
}
