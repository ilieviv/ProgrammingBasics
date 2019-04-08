using System;

namespace _05._Movie_Ratings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double max = double.MinValue;
            double min = double.MaxValue;
            double average = 0;

            string movieMin = string.Empty;
            string movieMax = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string movieName = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());

                if (rating < min)
                {
                    min = rating;
                    movieMin = movieName;
                }

                if (rating > max)
                {
                    max = rating;
                    movieMax = movieName;
                }

                average += rating;
            }

            average /= n;

            Console.WriteLine($"{movieMax} is with highest rating: {max:f1}");
            Console.WriteLine($"{movieMin} is with lowest rating: {min:f1}");
            Console.WriteLine($"Average rating: {average:f1}");
        }
    }
}
