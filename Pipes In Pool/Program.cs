using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int firstPipeDebitPerHour = int.Parse(Console.ReadLine());
            int secondPipeDebitPerHour = int.Parse(Console.ReadLine());
            double hoursWorkerMising = double.Parse(Console.ReadLine());

            double firstPipeQuantity = firstPipeDebitPerHour * hoursWorkerMising;
            double secondPipeQuantity = secondPipeDebitPerHour * hoursWorkerMising;
            double totalQuantityOfPipes = firstPipeQuantity + secondPipeQuantity;
            if (totalQuantityOfPipes <= volume)
            {
                double percentOfPool = (totalQuantityOfPipes / volume) * 100;
                double percentOfFirstPipe = (firstPipeQuantity / totalQuantityOfPipes) * 100;
                double percentOfSeconrPipe = (secondPipeQuantity / totalQuantityOfPipes) * 100;
                Console.WriteLine($"The pool is {percentOfPool:f2}% full. Pipe 1: {percentOfFirstPipe:f2}%. Pipe 2: {percentOfSeconrPipe:f2}%.");
            }
            else
            {
                double totalOverflows = totalQuantityOfPipes - volume;
                Console.WriteLine($"For {hoursWorkerMising:f2} hours the pool overflows with {totalOverflows:f2} liters.");
            }
        }
    }
}
