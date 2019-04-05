using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerOne = Console.ReadLine();
            string playerTwo = Console.ReadLine();

            string input = string.Empty;

            int playerOneScore = 0;
            int playerTwoScore = 0;

            while (input != "End of game")
            {
                input = Console.ReadLine();
                if (input == "End of game")
                {
                    break;
                }
                int first = int.Parse(input);

                input = Console.ReadLine();
                int second = int.Parse(input);

                if (first > second)
                {
                    playerOneScore += first - second;
                }
                else if (second > first)
                {
                    playerTwoScore += second - first;
                }
                else
                {
                    Console.WriteLine("Number wars!");

                    first = int.Parse(Console.ReadLine());
                    second = int.Parse(Console.ReadLine());

                    if (first > second)
                    {
                        Console.WriteLine($"{playerOne} is winner with {playerOneScore} points");
                    }
                    else if (second > first)
                    {
                        Console.WriteLine($"{playerTwo} is winner with {playerTwoScore} points");
                    }
                    return;
                }
            }
            Console.WriteLine($"{playerOne} has {playerOneScore} points" + Environment.NewLine + $"{playerTwo} has {playerTwoScore} points");

        }
    }
}
