using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbCount = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numbCount; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sum += numb;
                
            }
            Console.WriteLine(sum);
        }
    }
}
