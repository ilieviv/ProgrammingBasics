using System;

namespace _08._Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());

            for (int i = 1; i <= batches; i++)
            {
                bool flour = false;
                bool sugar = false;
                bool eggs = false;
                string products = string.Empty;

                while (products != "Bake!")
                {
                    products = Console.ReadLine();

                    if (products == "flour")
                    {
                        flour = true;
                    }

                    if (products == "sugar")
                    {
                        sugar = true;
                    }

                    if (products == "eggs")
                    {
                        eggs = true;
                    }

                    if (products == "Bake!")
                    {
                        if (flour && sugar && eggs)
                        {
                            Console.WriteLine("Baking batch number {0}...", i);
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            products = string.Empty;
                        }

                    }
                }

            }


        }
    }
}
