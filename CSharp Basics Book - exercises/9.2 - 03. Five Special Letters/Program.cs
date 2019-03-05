using System;

namespace _9._1___03._Five_Special_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            string pattern = "abcde";
            bool printed = false;

            for (int i1 = 0; i1 < 5; i1++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    for (int i3 = 0; i3 < 5; i3++)
                    {
                        for (int i4 = 0; i4 < 5; i4++)
                        {
                            for (int i5 = 0; i5 < 5; i5++)
                            {
                                string fullWord = ""
                                + pattern[i1]
                                + pattern[i2]
                                + pattern[i3]
                                + pattern[i4]
                                + pattern[i5];

                                string word = "" + fullWord[0];

                                for (int i = 1; i < fullWord.Length; i++)
                                {
                                    if (word.IndexOf(fullWord[i]) == -1)
                                    {
                                        word += fullWord[i];
                                    }
                                }

                                int sum = 0;

                                for (int l = 0; l < word.Length; l++)
                                {
                                    int add = 0;

                                    switch (word[l])
                                    {
                                        case 'a': add = 5; break;
                                        case 'b': add = -12; break;
                                        case 'c': add = 47; break;
                                        case 'd': add = 7; break;
                                        case 'e': add = -32; break;
                                    }

                                    sum += (l + 1) * add;
                                }

                                if (sum >= firstNumber && sum <= secondNumber)
                                {
                                    Console.Write(fullWord + " ");
                                    printed = true;
                                }
                            }
                        }
                    }
                }
            }
            if (!printed)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}

