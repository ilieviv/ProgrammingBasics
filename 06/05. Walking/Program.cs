using System;

namespace _05._Walking
{
	class Program
	{
		static void Main(string[] args)
		{
			int steps = 0;

			while (steps < 10000)
			{
				var command = Console.ReadLine();

				if (command == "Going home")
				{
					steps += int.Parse(Console.ReadLine());
					if (steps >= 10000)
					{
						Console.WriteLine("Goal reached! Good job!");
					}
					else
					{
						Console.WriteLine("{0} more steps to reach goal.", 10000 - steps);
					}
					break;
				}
				else
				{
					steps += int.Parse(command);
					if (steps >= 10000)
					{
						Console.WriteLine("Goal reached! Good job!");
					}
				}


			}
		}
	}
}
