using System;

namespace _03._Account_Balance
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int count = 0;
			double deposit = 0.0;
			double total = 0.0;

			while (count < n)
			{
				deposit = double.Parse(Console.ReadLine());

				if (deposit < 0)
				{
					Console.WriteLine("Invalid operation!");
					break;
				}
				
				total += deposit;
				Console.WriteLine("Increase: {0:f2}", deposit);
				count++;
			}

			Console.WriteLine("Total: {0:f2}", total);
		}
	}
}
