using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double wightInMetеrs = double.Parse(Console.ReadLine());
            double heightInMeters = double.Parse(Console.ReadLine());
            const double heightRow = 70;
            const double wightRow = 120;
            double wightInCentimeters = wightInMetеrs * 100;
            double heightInCentimeters = heightInMeters * 100 - 100;

            double countOfRow = (heightInCentimeters - heightInCentimeters % heightRow) / heightRow;
            double countOfColumn = (wightInCentimeters - wightInCentimeters % wightRow) / wightRow;
            double totalSeats = countOfColumn * countOfRow - 3;
            Console.WriteLine(totalSeats);
        }
    }
}
