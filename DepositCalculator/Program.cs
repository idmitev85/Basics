using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double mounth = double.Parse(Console.ReadLine());
            double profi = double.Parse(Console.ReadLine());
            double result = money + mounth * (( money * ( profi / 100) )/12);
            Console.WriteLine(result);
        }
    }
}
