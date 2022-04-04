using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double DOG = 2.50;
            const double CAT = 4.00;
            double num = double.Parse(Console.ReadLine());
            double numb = double.Parse(Console.ReadLine());
            double dogs  = num * DOG;
            double cats = numb * CAT;
            double result = dogs + cats;
            Console.WriteLine($"{result} lv.");

        }
    }
}
