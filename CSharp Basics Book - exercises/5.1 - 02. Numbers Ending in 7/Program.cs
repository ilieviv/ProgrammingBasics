using System;

namespace _5._1___02._Numbers_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=1000; i++)
            {
                if (i % 10 ==7)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
