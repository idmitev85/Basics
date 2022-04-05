using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCm = int.Parse(Console.ReadLine());
            int widthCm = int.Parse(Console.ReadLine());
            int hеightCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int volumeAq = lenghtCm * widthCm * hеightCm;
            double volumeLt = volumeAq / 1000.00;
            double volumeNeed = volumeLt * (1 - percent / 100);
            Console.WriteLine(volumeNeed);
        }
    }
}
