using System;

namespace Birthday
{
	class Program
	{
		static void Main(string[] args)
		{
			double l = double.Parse(Console.ReadLine());
			double w = double.Parse(Console.ReadLine());
			double h = double.Parse(Console.ReadLine());
			double p = double.Parse(Console.ReadLine());

			double area = (l * w * h);
			double parea = (p/100 * area);
			double litres = (area - parea)/1000;

			Console.WriteLine("{0:F3}", litres);

		}
	}
}
