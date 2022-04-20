using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbCount = int.Parse(Console.ReadLine());
            int maxNumb = int.MinValue;
            int minNumb = int.MaxValue;
            
            
            for (int i = 0; i < numbCount; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                if (numb > maxNumb)
                {
                    maxNumb = numb;
                }
                if (numb < minNumb)
                {
                    minNumb = numb;
                }
                
            }
            Console.WriteLine("Max number: " + maxNumb);
            Console.WriteLine("Min number: " + minNumb);
        }
    }
}
