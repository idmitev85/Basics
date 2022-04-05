using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veg = int.Parse(Console.ReadLine());
            double sum = chicken * 10.35 + fish * 12.40 + veg * 8.15;
            double desertPrice = 0.20 * sum;
            double allPrice = sum + desertPrice + 2.50;
            Console.WriteLine(allPrice);
        }
    }
}
