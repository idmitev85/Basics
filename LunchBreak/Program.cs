using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string tvSeries = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            double brakeTime = double.Parse(Console.ReadLine());

            double lunchTimeBrake = brakeTime / 8;
            double relaxTime = brakeTime / 4;
            double timeLeft = brakeTime - (lunchTimeBrake + relaxTime);
            double needTime = Math.Abs(episodeTime - timeLeft);
            Console.WriteLine(timeLeft >= episodeTime ? $"You have enough time to watch {tvSeries} and left with {Math.Ceiling(needTime)} minutes free time.": $"You don't have enough time to watch {tvSeries}, you need {Math.Ceiling(needTime)} more minutes." );
        }
    }
}
