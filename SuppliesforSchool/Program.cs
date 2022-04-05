using System;

namespace SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int mark = int.Parse(Console.ReadLine());
            int clean = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double all = (pen * 5.80) + (mark * 7.20) + (clean * 1.20);
            double disc = all * (discount / 100.0);
            double result = all - disc;
            Console.WriteLine(result);
        }
    }
}
