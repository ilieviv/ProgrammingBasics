using System;

namespace USD_to_BGN
{
	class Program
	{
		static void Main(string[] args)
		{
			double usd = double.Parse(Console.ReadLine());
			double fixing = 1.79549;

			//double bgn = usd * fixing;
			double bgn = Math.Round(usd * fixing, 2);

			Console.WriteLine("{0:f2}", bgn);
		}
	}
}
