using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = string.Empty;
            int seats = 0;

            int studentTickets = 0;
            int standartTickets = 0;
            int kidTickets = 0;

            string typeTickets = string.Empty;

            while (movieName != "Finish")
            {
                movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }

                int freeSeats = int.Parse(Console.ReadLine());

                while (seats < freeSeats)
                {
                    typeTickets = Console.ReadLine();

                    if (typeTickets == "End")
                    {
                        break;
                    }

                    seats++;

                    if (typeTickets == "student")
                    {
                        studentTickets++;
                    }
                    else if (typeTickets == "standard")
                    {
                        standartTickets++;
                    }
                    else if (typeTickets == "kid")
                    {
                        kidTickets++;
                    }
                }

                double capacity = seats / (double)freeSeats * 100;
                Console.WriteLine($"{movieName} - {capacity:f2}% full.");
                seats = 0;
            }

            int totalTicets = studentTickets + standartTickets + kidTickets;

            Console.WriteLine($"Total tickets: {totalTicets}");
            Console.WriteLine($"{(studentTickets / (double)totalTicets * 100):f2}% student tickets.");
            Console.WriteLine($"{(standartTickets / (double)totalTicets * 100):f2}% standard tickets.");
            Console.WriteLine($"{(kidTickets / (double)totalTicets * 100):f2}% kids tickets.");
        }
    }
}
