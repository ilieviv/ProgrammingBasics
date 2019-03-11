using System;

namespace _04._Number_sequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int max = int.MinValue;
			int min = int.MaxValue;
			string input = Console.ReadLine();
			var num = 0;

			while (input != "END")
			{
				num = int.Parse(input);

				if (num > max)
				{
					max = num;
				}
				if (num < min)
				{
					min = num;
				}
				input = Console.ReadLine();
			}

			Console.WriteLine("Max number: " + max);
			Console.WriteLine("Min number: " + min);
		}
	}
}
