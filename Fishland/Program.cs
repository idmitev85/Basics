using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfMackerel = double.Parse(Console.ReadLine());
            double priceOfSprat = double.Parse(Console.ReadLine());
            double quantityOfBonito = double.Parse(Console.ReadLine());
            double quantityOfScad = double.Parse(Console.ReadLine());
            int quantityOfMussels = int.Parse(Console.ReadLine());
            const double priceOfMussels = 7.50;

            double totalPriceOfBonito = priceOfMackerel * 1.60;
            double totalPriceOfScad = priceOfSprat * 1.80;

            double neededMoney = Math.Abs(totalPriceOfBonito * quantityOfBonito
                + totalPriceOfScad * quantityOfScad
                + priceOfMussels * quantityOfMussels);
            Console.WriteLine($"{neededMoney:f2}");
        }
    }
}
