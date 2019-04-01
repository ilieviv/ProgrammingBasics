using System;

namespace _05._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());

            int counter = 0;
            string pass = string.Empty;

            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 0; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            bool firstCondition = (d1 * d2) + (d3 * d4) == m;
                            bool secondCondition = d1 < d2 && d3 > d4;
                            if (firstCondition && secondCondition)
                            {
                                Console.Write("{0}{1}{2}{3} ", d1, d2, d3, d4);
                                counter++;

                                if (counter == 4)
                                {
                                    pass = d1.ToString() + d2.ToString() + d3.ToString() + d4.ToString();
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            if (pass != string.Empty)
            {
                Console.WriteLine("Password: {0}", pass);
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
