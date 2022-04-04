using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            const int PROJ = 3;
            int number = int.Parse(Console.ReadLine());
            int hours = number * PROJ;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {number} project/s.");
        }
    }
}
