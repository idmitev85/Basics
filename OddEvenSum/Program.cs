using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbCount = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;


            for (int i = 0; i < numbCount; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numb;
                }
                else
                {
                    oddSum += numb;
                }
                
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(evenSum - oddSum));
            }
            //if (sum1 == sum2)
            //{
            //    Console.WriteLine("Yes");
            //    Console.WriteLine("Sum = " + sum1);
            //}
        }
    }
}
