using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());
            double tranerPrice = 0.6 * taxPerYear;
            double outfitPrice = 0.8 * tranerPrice;
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;
            double expenses = taxPerYear + tranerPrice + outfitPrice + ballPrice + accPrice;
            Console.WriteLine(expenses);
        }
    }
}
