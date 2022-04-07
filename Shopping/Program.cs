using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfVideoCards = int.Parse(Console.ReadLine());
            int numberOfProcessors = int.Parse(Console.ReadLine());
            int numberOfRamMemory = int.Parse(Console.ReadLine());

            const double videoCardPrice = 250;
            double totalVideoCardPrice = videoCardPrice * numberOfVideoCards;
            double totalProcessorPrice = totalVideoCardPrice * 0.35;
            double totalRamMemoryPrice = totalVideoCardPrice * 0.10;
            
            double totalMoney = totalVideoCardPrice + totalProcessorPrice * numberOfProcessors + totalRamMemoryPrice * numberOfRamMemory;
            if (numberOfVideoCards > numberOfProcessors)
            {
                totalMoney *= 0.85;
            }
            double difference = Math.Abs(totalMoney - budget);
            Console.WriteLine(budget >= totalMoney ?$"You have {difference:f2} leva left!" :$"Not enough money! You need {difference:f2} leva more!");
        }
    }
}
