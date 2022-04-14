using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            const int workingHours = 8;
            const int overtimePerDay = 2;

            int hoursNeededToFinishTheProject = int.Parse(Console.ReadLine());
            int daysToFinishTheProject = int.Parse(Console.ReadLine());
            int countOfWorkersOvertime = int.Parse(Console.ReadLine());

            double workedHours = (daysToFinishTheProject * 0.9) * workingHours;
            double totalOvertime = countOfWorkersOvertime * (overtimePerDay * daysToFinishTheProject);
            double totalHours = Math.Floor(workedHours + totalOvertime);
            if (totalHours >= hoursNeededToFinishTheProject)
            {
                Console.WriteLine($"Yes!{(totalHours - hoursNeededToFinishTheProject)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeededToFinishTheProject - totalHours} hours needed.");
            }
        }
    }
}
