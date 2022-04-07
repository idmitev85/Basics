using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (numb <= 100) 
            {
                bonus = 5;
            }
            
            else if (numb > 1000)
            {
                bonus = numb * 0.1;
            }

            else
            {
                bonus = numb * 0.2;
            }

            if (numb % 2 == 0)
            {
                bonus = bonus + 1;
            }
            
            else if (numb % 10 == 5)
            {
                bonus += 2;
            }
            
            Console.WriteLine(bonus);
            Console.WriteLine(numb + bonus);
        }
    }
}
