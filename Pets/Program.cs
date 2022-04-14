using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());
            int foodLeftInKilograms = int.Parse(Console.ReadLine());
            double foodPerDayForDogInKilograms = double.Parse(Console.ReadLine());
            double foodPerDayForCatInKilograms = double.Parse(Console.ReadLine());
            double foodPerDayForTurtleInGrams = double.Parse(Console.ReadLine());

            double neededFoodForDog = countOfDays * foodPerDayForDogInKilograms;
            double neededFoodForCat = countOfDays * foodPerDayForCatInKilograms;
            double neededFoodForTurtle = countOfDays * (foodPerDayForTurtleInGrams / 1000);
            double totalFoodNeeded = neededFoodForCat + neededFoodForDog + neededFoodForTurtle;
            if (foodLeftInKilograms >= totalFoodNeeded)
            {
                double foodLeft = Math.Floor(foodLeftInKilograms - totalFoodNeeded);
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else
            {
                double foodNeeded = Math.Ceiling(totalFoodNeeded - foodLeftInKilograms);
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
