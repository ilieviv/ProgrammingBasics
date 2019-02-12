using System;

namespace _3._1___16._Number_0to100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dWhole =0;
            int dPart= 0;

            string word="";
            string second = "";

             if (n == 0)
            {
                Console.Write("zero");
            }
            if (n <= 10)
            {
                if (n == 1)
                {
                    word = "one";
                }
                else if (n == 2)
                {
                    word = "two";
                }
                else if (n == 3)
                {
                    word = "three";
                }
                else if (n == 4)
                {
                    word = "four";
                }
                else if (n == 5)
                {
                    word = "five";
                }
                else if (n == 6)
                {
                    word = "six";
                }
                else if (n == 7)
                {
                    word = "seven";
                }
                else if (n == 8)
                {
                    word = "eight";
                }
                else if (n == 9)
                {
                    word = "nine";
                }
                else if (n == 10)
                {
                    word = "ten";
                }
                Console.WriteLine(word);
            }
            else if (n>=10 && n<100)
            {
                dWhole = n / 10;
                dPart = n % 10;

                if (dPart == 1)
                {
                    second = "one";
                }
                else if (dPart == 2)
                {
                    second = "two";
                }
                else if (dPart == 3)
                {
                    second = "three";
                }
                else if (dPart == 4)
                {
                    second = "four";
                }
                else if (dPart == 5)
                {
                    second = "five";
                }
                else if (dPart == 6)
                {
                    second = "six";
                }
                else if (dPart == 7)
                {
                    second = "seven";
                }
                else if (dPart == 8)
                {
                    second = "eight";
                }
                else if (dPart == 9)
                {
                    second = "nine";
                }

                if (dWhole==1)
                {
                    if (dPart==1)
                    {
                        Console.WriteLine
                            ("eleven");
                    }
                    else if (dPart== 2)
                    {
                        Console.WriteLine("twelve");
                    }
                    else if (dPart == 3)
                    {
                        Console.WriteLine("thirteen");
                    }
                    else if (dPart == 4)
                    {
                        Console.WriteLine("fourteen");
                    }
                    else if (dPart == 5)
                    {
                        Console.WriteLine("fiveteen");
                    }
                    else if (dPart == 6)
                    {
                        Console.WriteLine("sixteen");
                    }
                    else if (dPart == 7)
                    {
                        Console.WriteLine("seventeen");
                    }
                    else if (dPart == 8)
                    {
                        Console.WriteLine("eighteen");
                    }
                    else if (dPart == 9)
                    {
                        Console.WriteLine("nineteen");
                    }
                   
                }
                else if (dWhole ==2)
                {
                    word = "twenty";
                }
                else if (dWhole == 3)
                {
                    word = "thirty";
                }
                else if (dWhole == 4)
                {
                    word = "forty";
                }
                else if (dWhole == 5)
                {
                    word = "fifty";
                }
                else if (dWhole == 6)
                {
                    word = "sixty";
                }
                else if (dWhole == 7)
                {
                    word = "seventy";
                }
                else if (dWhole == 8)
                {
                    word = "eighty";
                }
                else if (dWhole == 9)
                {
                    word = "ninety";
                }


                if (dWhole==1)
                {
                        Console.Write($"{word}");
                }
                else if (dPart==0)
                {
                    Console.WriteLine($"{word}");
                }
                else
                {
                    Console.WriteLine($"{word} {second}");
                }
            }
            else if (n==100)
            {
                Console.WriteLine("hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
