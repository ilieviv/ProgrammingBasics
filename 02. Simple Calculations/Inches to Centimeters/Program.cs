using System;

namespace Inches_to_Centimeters
{
	class Program
	{
		static void Main(string[] args)
		{
			double n = double.Parse(Console.ReadLine());
			double i = 2.54;
			double r = n * i; 
			
			Console.WriteLine("{0:F2}", r);
		}
	}
}
