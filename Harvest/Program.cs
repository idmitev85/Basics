using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            const double percentageForWine = 0.4;
            const double neededGrapesPerLiter = 2.5;
            
            int squareMetersVineyard = int.Parse(Console.ReadLine());
            double grapesForOneSquareMeter = double.Parse(Console.ReadLine());
            int neededLitersOfWine = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = squareMetersVineyard * grapesForOneSquareMeter;
            double totalWine = totalGrapes * percentageForWine / neededGrapesPerLiter;
            if (totalWine >= neededLitersOfWine)
            {
                double litersLeft = totalWine - neededLitersOfWine;
                double litersPerWorker = litersLeft / countOfWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersLeft)} liters left -> {Math.Ceiling(litersPerWorker)} liters per person.");
            }
            else
            {
                double litersNeeded = neededLitersOfWine - totalWine;                
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersNeeded)} liters wine needed.");
            }                
        }
    }
}
