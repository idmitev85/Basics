using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            const double YARD = 7.61;
            const double OFF = 0.18;
            double num = double.Parse(Console.ReadLine());
            double all = num * YARD;
            double priceoff = all * OFF;
            double result = all - priceoff;
            Console.WriteLine($"The final price is {result} lv.");
            Console.WriteLine($"The discount is {priceoff} lv.");
        }
    }
}
