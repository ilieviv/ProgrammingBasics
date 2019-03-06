using System;

namespace _9._2___03._Bulls_and_Cows
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bulls = int.Parse(Console.ReadLine());
            int cows = int.Parse(Console.ReadLine());

            bool solutionFound = false;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {

                            int guesNumb1 = (number / 1000) % 10;
                            int guesNumb2 = (number / 100) % 10;
                            int guesNumb3 = (number / 10) % 10;
                            int guesNumb4 = (number / 1) % 10;

                            int digitToCheck1 = i;
                            int digitToCheck2 = j;
                            int digitToCheck3 = k;
                            int digitToCheck4 = l;

                            int currentBulls = 0;
                            int currentCows = 0;

                            // Find all bulls, count them and remove them (assign -1 and -2)
                            if (digitToCheck1 == guesNumb1)
                            {
                                currentBulls++;
                                guesNumb1 = -1;
                                digitToCheck1 = -2;
                            }
                            if (digitToCheck2 == guesNumb2)
                            {
                                currentBulls++;
                                guesNumb2 = -1;
                                digitToCheck2 = -2;
                            }
                            if (digitToCheck3 == guesNumb3)
                            {
                                currentBulls++;
                                guesNumb3 = -1;
                                digitToCheck3 = -2;
                            }
                            if (digitToCheck4 == guesNumb4)
                            {
                                currentBulls++;
                                guesNumb4 = -1;
                                digitToCheck4 = -2;
                            }

                            //COWS /n1
                            if (digitToCheck1 == guesNumb2)
                            {
                                currentCows++;
                                guesNumb2 = -1;
                            }
                            else if (digitToCheck1 == guesNumb3)
                            {
                                currentCows++;
                                guesNumb3 = -1;
                            }
                            else if (digitToCheck1 == guesNumb4)
                            {
                                currentCows++;
                                guesNumb4 = -1;
                            }

                            //n2
                            if (digitToCheck2 == guesNumb1)
                            {
                                currentCows++;
                                guesNumb1 = -1;
                            }
                            else if (digitToCheck2 == guesNumb3)
                            {
                                currentCows++;
                                guesNumb3 = -1;
                            }
                            else if (digitToCheck2 == guesNumb4)
                            {
                                currentCows++;
                                guesNumb4 = -1;
                            }

                            //n3
                            if (digitToCheck3 == guesNumb1)
                            {
                                currentCows++;
                                guesNumb1 = -1;
                            }
                            else if (digitToCheck3 == guesNumb2)
                            {
                                currentCows++;
                                guesNumb2 = -1;
                            }
                            else if (digitToCheck3 == guesNumb4)
                            {
                                currentCows++;
                                guesNumb4 = -1;
                            }

                            //n4
                            if (digitToCheck4 == guesNumb1)
                            {
                                currentCows++;
                                guesNumb1 = -1;
                            }
                            else if (digitToCheck4 == guesNumb2)
                            {
                                currentCows++;
                                guesNumb2 = -1;
                            }
                            else if (digitToCheck4 == guesNumb3)
                            {
                                currentCows++;
                                guesNumb3 = -1;
                            }

                            if (currentBulls == bulls && currentCows == cows)
                            {
                                if (solutionFound)
                                {
                                    Console.Write(" ");
                                }

                                Console.Write("{0}{1}{2}{3}", i, j, k, l);
                                solutionFound = true;
                            }

                        }
                    }
                }
            }

            if (!solutionFound)
            {
                Console.Write("No");
            }
        }
    }
}
