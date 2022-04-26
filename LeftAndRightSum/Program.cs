using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbCount = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < numbCount; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sum1 += numb;
            }
            for (int i = 2; i < numbCount + 2; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                sum2 += numb;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = " + sum1);
            }
            else if (sum1 != sum2)
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff = " + diff);
            }

        }
    }
}
