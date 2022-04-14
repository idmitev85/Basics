using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double priceOfMagnolias = 3.25;
            const double priceOfHyacinths = 4;
            const double priceOfRoses = 3.5;
            const double priceOfCactuses = 8;

            int countOfMagnolias = int.Parse(Console.ReadLine());
            int countOfHyacinths = int.Parse(Console.ReadLine());
            int countOfRoses = int.Parse(Console.ReadLine());
            int countOfCactuses = int.Parse(Console.ReadLine());
            double priceOfGift = double.Parse(Console.ReadLine());

            double totalPriceOfFlowers = (countOfMagnolias * priceOfMagnolias + countOfHyacinths * priceOfHyacinths + countOfRoses * priceOfRoses + countOfCactuses * priceOfCactuses) * 0.95;
            if (priceOfGift > totalPriceOfFlowers)
            {
                double neededMoney = Math.Ceiling(priceOfGift - totalPriceOfFlowers);
                Console.WriteLine($"She will have to borrow {neededMoney} leva.");
            }
            else
            {
                double leftMoney = Math.Floor(totalPriceOfFlowers - priceOfGift);
                Console.WriteLine($"She is left with {leftMoney} leva.");
            }
        }
    }
}
