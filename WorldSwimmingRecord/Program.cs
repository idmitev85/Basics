using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMetres = double.Parse(Console.ReadLine());
            double timeSecundsForOneMeter = double.Parse(Console.ReadLine());

            double neededTime =distanceMetres * timeSecundsForOneMeter;
            double resistance = Math.Floor(distanceMetres / 15) * 12.5;
            double totalTime = neededTime + resistance;
            if (recordSeconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - recordSeconds):f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
