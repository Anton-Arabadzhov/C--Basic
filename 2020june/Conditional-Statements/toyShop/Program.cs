using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double countsJigsaws = double.Parse(Console.ReadLine());
            double countsDolls = double.Parse(Console.ReadLine());
            double countsBears = double.Parse(Console.ReadLine());
            double countsMinions = double.Parse(Console.ReadLine());
            double countsTrucks = double.Parse(Console.ReadLine());

            double jigsawsPrice = countsJigsaws * 2.6;
            double dollsPrice = countsDolls * 3;
            double bearsPrice = countsBears * 4.1;
            double minionPrice = countsMinions * 8.2;
            double trucksPrice = countsTrucks * 2;

            double allToys = countsJigsaws + countsMinions + countsTrucks + countsDolls + countsBears;
            double v = jigsawsPrice + dollsPrice + bearsPrice + minionPrice;
            double moneyFromSales = v + trucksPrice;
            if (allToys >= 50)
            {
                
                double priceDiscount = moneyFromSales * 0.75;
                double leftMoney = priceDiscount * 0.90;


                if (leftMoney >= tripPrice)
                {
                    
                    double  TripBugged = leftMoney - tripPrice;
                    Console.WriteLine($"Yes! {TripBugged:f2} lv left.");
                }
                else
                {

                    
                    double TripBugged = tripPrice - leftMoney;
                    Console.WriteLine($"Not enough money! {TripBugged:f2} lv needed.");
                }

            }
            else
            {
                double leftMoney = moneyFromSales * 0.90;
                if (leftMoney >= tripPrice)
                {

                    double tripMoney = leftMoney - tripPrice;
                    Console.WriteLine($"Yes! {tripMoney:f2} lv left.");
                }
                else
                {


                    double tripMoney = tripPrice - leftMoney;
                    Console.WriteLine($"Not enough money! {tripMoney:f2} lv needed.");
                }
            }
            
        }
    }
}
