using System;

namespace _8._2___02._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savedMoney = decimal.Parse(Console.ReadLine());
            decimal floorWidth = decimal.Parse(Console.ReadLine());
            decimal floorLength = decimal.Parse(Console.ReadLine());
            decimal a = decimal.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal tilePrice = decimal.Parse(Console.ReadLine());
            decimal masterPrice = decimal.Parse(Console.ReadLine());

            decimal areaFloor = floorLength * floorWidth;
            decimal areaTile = a * h / 2;
            decimal totalTiles = Math.Ceiling(areaFloor / areaTile) + 5;
            decimal priceTiles = totalTiles * tilePrice;
            decimal difference = savedMoney - masterPrice - priceTiles;

            if (difference >= 0)
            {
                Console.WriteLine("{0:f2} lv left.", difference);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(difference));
            }

        }
    }
}
