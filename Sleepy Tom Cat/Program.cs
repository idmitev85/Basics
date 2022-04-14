using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minutesForPlayOnWork = 63;
            const int minutesForPlayOnRest = 127;
            const int neededMinutesPerYear = 30000;
            const int daysOfYear = 365;
            int countOfFreeDays = int.Parse(Console.ReadLine());

            int minutesForPlayOnFreeDays = countOfFreeDays * minutesForPlayOnRest;
            int minutesForPlayOnWorkDays = (daysOfYear - countOfFreeDays) * minutesForPlayOnWork;
            int totalMinutesForPlayPerYear = minutesForPlayOnFreeDays + minutesForPlayOnWorkDays;
            if (neededMinutesPerYear > totalMinutesForPlayPerYear)
            {
                int minutesLeft = neededMinutesPerYear - totalMinutesForPlayPerYear;
                int hours = minutesLeft / 60;
                int minutes = minutesLeft % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else if (neededMinutesPerYear < totalMinutesForPlayPerYear)
            {
                int minutesLeft = totalMinutesForPlayPerYear - neededMinutesPerYear;
                int hours = minutesLeft / 60;
                int minutes = minutesLeft % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
