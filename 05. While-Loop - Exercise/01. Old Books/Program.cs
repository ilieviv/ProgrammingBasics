using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int shelfCapacity = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter < shelfCapacity)
            {
                string book = Console.ReadLine();
                

                if (book == searchedBook)
                {
                    Console.WriteLine("You checked {0} books and found it.", counter);
                    break;
                }
                counter++;
            }

            if (counter == shelfCapacity)
            {
                Console.WriteLine("The book you search is not here!\nYou checked {0} books.", shelfCapacity);
            }

        }
    }
}
