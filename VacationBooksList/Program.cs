using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int all = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int result = ( all / count ) / days;
            Console.WriteLine(result);
        }
    }
}
