using System;

namespace _8._2___06._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = char.Parse(Console.ReadLine());
            var c2 = char.Parse(Console.ReadLine());
            var c3 = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int f = c1; f <= c2; f++)
            {
                for (int s = c1; s <= c2; s++)
                {
                    for (int t = c1; t <= c2; t++)
                    {
                        if (f != c3 && s != c3 && t != c3)
                        {
                            Console.Write("{0}{1}{2} ", (char)f, (char)s, (char)t);
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}
