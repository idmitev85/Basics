using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightOfHouse = double.Parse(Console.ReadLine());
            double leghtOfHouseSide = double.Parse(Console.ReadLine());
            double heightOfRoof = double.Parse(Console.ReadLine());

            double areaOfDoor = 1.2 * 2;
            double areaOfWindows = 2 * (1.5 * 1.5);
            
            const double areaOfGreenPaintPerLitre = 3.4;
            const double areaOfRedPaintPerLitre = 4.3;
            double totalAreaOfWalls = (leghtOfHouseSide * heightOfHouse) * 2 - areaOfWindows
                + (heightOfHouse * heightOfHouse) * 2 - areaOfDoor;
            double totalAreaOfRoof = (heightOfHouse * heightOfRoof / 2) * 2
                + (heightOfHouse * leghtOfHouseSide) * 2;
            double quantityOfGreenPaint = totalAreaOfWalls / areaOfGreenPaintPerLitre;
            double quantityOfRedPaint = totalAreaOfRoof / areaOfRedPaintPerLitre;
            Console.WriteLine($"{quantityOfGreenPaint:f2}");
            Console.WriteLine($"{quantityOfRedPaint:f2}");
        }
    }
}
