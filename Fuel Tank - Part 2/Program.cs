using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gasolinePricePerLiter = 2.22;
            const double dieselPricePerLiter = 2.33;
            const double gasPricePerLiter = 0.93;
             
            const double discountPerLiterGasoline = 0.18;
            const double discountPerLiterDiesel = 0.12;
            const double discountPerLiterGas = 0.08;           

            string typeOfFuel = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double priceOfLiterGasWithDiscount = 0;
            double priceOfLiterGasolineWithDiscount = 0;
            double priceOfLiterDieselWithDiscount = 0;            
            double totalPriceOfFuel = 0;

            if (typeOfFuel == "Gas")
            {
                if (clubCard == "Yes")
                {
                    priceOfLiterGasWithDiscount = gasPricePerLiter - discountPerLiterGas;
                }
                else
                {
                    priceOfLiterGasWithDiscount = gasPricePerLiter;
                }
                totalPriceOfFuel = fuelQuantity * priceOfLiterGasWithDiscount;
            }
            else if (typeOfFuel == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    priceOfLiterGasolineWithDiscount = gasolinePricePerLiter - discountPerLiterGasoline;
                }
                else
                {
                    priceOfLiterGasolineWithDiscount = gasolinePricePerLiter;
                }
                totalPriceOfFuel = fuelQuantity * priceOfLiterGasolineWithDiscount;
            }
            else if (typeOfFuel == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    priceOfLiterDieselWithDiscount = dieselPricePerLiter - discountPerLiterDiesel;
                }
                else
                {
                    priceOfLiterDieselWithDiscount = dieselPricePerLiter;
                }
                totalPriceOfFuel = fuelQuantity * priceOfLiterDieselWithDiscount;
            }            
            if (fuelQuantity > 20 && fuelQuantity <= 25)
            {
                totalPriceOfFuel *= 0.92;                
            }
            else if (fuelQuantity > 25)
            {
                totalPriceOfFuel *= 0.90;                
            }
            Console.WriteLine($"{totalPriceOfFuel:f2} lv.");           
        }
    }
}
