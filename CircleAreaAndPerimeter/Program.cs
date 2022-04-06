using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());
            double calculatedArea = Math.PI * (circleRadius * circleRadius);
            double calculatedPerimeter = 2 * Math.PI * circleRadius;
            Console.WriteLine($"{calculatedArea:f2}");
            Console.WriteLine($"{calculatedPerimeter:f2}");
        }
    }
}
