using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priseForOneVegetables = double.Parse(Console.ReadLine());
            double priseForOneFruit = double.Parse(Console.ReadLine());
            int quantityOfVegetables = int.Parse(Console.ReadLine());
            int quantityOfFruit = int.Parse(Console.ReadLine());
            const double euro = 1.94;

            double totalPrice = priseForOneVegetables * quantityOfVegetables + priseForOneFruit * quantityOfFruit;
            double totalPriceInEuro = totalPrice / 1.94;
            Console.WriteLine($"{totalPriceInEuro:f2}");
        }
    }
}
