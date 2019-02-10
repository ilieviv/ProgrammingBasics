using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double priceTable = 7;
            double priceKare = 9;
            double usd = 1.85;

            double kareLength = length * 0.5;

            double tableDimension = (length + 0.3+0.3) * (width + 0.3+0.3);
            double areaTables = tables * tableDimension;

            double kareDimension = kareLength * kareLength;
            double areaKare = tables * kareDimension;

            double priceTablesUSD = areaTables * priceTable;
            double priceKaresUSD = areaKare * priceKare;

            double priceTablesBGN = priceTablesUSD * usd;
            double priceKaresBGN = priceKaresUSD * usd;

            double sumUSD = priceTablesUSD + priceKaresUSD;
            double sumBGN = priceTablesBGN + priceKaresBGN;

            //Console.WriteLine("{0:f2} USD", sumUSD);
            //Console.WriteLine("{0:f2} BGN", sumBGN);
            Console.WriteLine($"{sumUSD:f2} USD");
            Console.WriteLine($"{sumBGN:f2} BGN");

        }
    }
}
