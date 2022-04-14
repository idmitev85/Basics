using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxiStartPrice = 0.70;
            const double taxiDayPricePerKilometer = 0.79;
            const double taxiNightPricePerKilometer = 0.90;
            const double busPricePerKilometer = 0.09;
            const double trainPricePerKilometer = 0.06;

            int kilometers = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double totalPrice = 0;
            if (kilometers < 20)
            {
                if (timeOfDay == "day")
                {
                    totalPrice = taxiStartPrice + (taxiDayPricePerKilometer * kilometers);
                }
                else if (timeOfDay == "night")
                {
                    totalPrice = taxiStartPrice + (taxiNightPricePerKilometer * kilometers);
                }
            }
            else if (kilometers < 100)
            {
                totalPrice = busPricePerKilometer * kilometers;
            }
            else
            {
                totalPrice = trainPricePerKilometer * kilometers;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
