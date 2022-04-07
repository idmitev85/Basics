using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrise = 2.60;
            const double dollPrise = 3.00;
            const double bearPrise = 4.10;
            const double minionPrise = 8.20;
            const double truckPrise = 2.00;

            double tripPrise = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            int toysCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            double toysPrise = puzzleCount * puzzlePrise + dollCount * dollPrise + bearCount * bearPrise + minionCount * minionPrise + truckCount * truckPrise;

            if (toysCount >= 50)
            {
                toysPrise *= 0.75;
                
            }
            double rent = toysPrise * 0.10;
            double diference = Math.Abs(rent + tripPrise - toysPrise);
            if (toysPrise >= rent + tripPrise)
            {
                Console.WriteLine($"Yes! {diference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diference:f2} lv needed.");
            }
        }
    }
}
