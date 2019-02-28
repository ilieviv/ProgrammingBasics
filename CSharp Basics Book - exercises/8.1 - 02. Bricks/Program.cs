using System;

namespace _8._1___02._Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int oneCourse = w * m;

            double courses = Math.Ceiling((double)x / oneCourse);
            Console.WriteLine(courses);
        }
    }
}
