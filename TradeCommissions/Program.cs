using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sellSize = double.Parse(Console.ReadLine());

            double comisionsPercentаge = 0;
            
            switch (city)
            {
                case "Sofia":
                    if (sellSize >= 0 && sellSize <= 500)
                    {
                        comisionsPercentаge = 0.05;
                    }
                    else if (sellSize > 500 && sellSize <= 1000)
                    {
                        comisionsPercentаge = 0.07;
                    }
                    else if (sellSize > 1000 && sellSize <= 10000)
                    {
                        comisionsPercentаge = 0.08;
                    }
                    else if (sellSize > 10000)
                    {
                        comisionsPercentаge = 0.12;
                    }
                    break;
                case "Varna":
                    if (sellSize >= 0 && sellSize <= 500)
                    {
                        comisionsPercentаge = 0.045;
                    }
                    else if (sellSize > 500 && sellSize <= 1000)
                    {
                        comisionsPercentаge = 0.075;
                    }
                    else if (sellSize > 1000 && sellSize <= 10000)
                    {
                        comisionsPercentаge = 0.10;
                    }
                    else if (sellSize > 10000)
                    {
                        comisionsPercentаge = 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (sellSize >= 0 && sellSize <= 500)
                    {
                        comisionsPercentаge = 0.055;
                    }
                    else if (sellSize > 500 && sellSize <= 1000)
                    {
                        comisionsPercentаge = 0.08;
                    }
                    else if (sellSize > 1000 && sellSize <= 10000)
                    {
                        comisionsPercentаge = 0.12;
                    }
                    else if (sellSize > 10000)
                    {
                        comisionsPercentаge = 0.145;
                    }
                    break;
                
            }
            if ((sellSize >= 0 && city == "Plovdiv") 
                || (sellSize >= 0 && city == "Sofia") 
                || (sellSize >= 0 && city == "Varna"))
            {
                Console.WriteLine($"{sellSize * comisionsPercentаge:f2}");
            }
            else                
            {
                Console.WriteLine("error");
            }

        }
    }
}
