using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistCount = int.Parse(Console.ReadLine());
            double statistCoutPrisePerPerson = double.Parse(Console.ReadLine());

            double statistPrise = statistCount * statistCoutPrisePerPerson;
            double decorPrise = budget * 0.10;
            if (statistCount > 150)
            {
                statistPrise *= 0.90;
            }
            double totalMoney = decorPrise + statistPrise;
            if (totalMoney > budget)
            {
                double needMoney = totalMoney - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
