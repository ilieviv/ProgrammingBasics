using System;

namespace _9._2___01._Passion_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal shopingmoney = decimal.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int purchases = 0;

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }
            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                foreach (char action in command)
                {
                    if (action >= 'A' && action <= 'Z')
                    {
                        decimal price = action * 0.5m;
                        if (shopingmoney < price)
                        {
                            continue;
                        }

                        shopingmoney -= price;
                        purchases++;
                    }
                    else if (action >= 'a' && action <= 'z')
                    {
                        decimal price = action * 0.3m;
                        if (shopingmoney < price)
                        {
                            continue;
                        }

                        shopingmoney -= price;
                        purchases++;
                    }
                    else if (action == '%')
                    {
                        decimal price = shopingmoney / 2m;
                        if (shopingmoney < price || shopingmoney == 0)
                        {
                            continue;
                        }

                        shopingmoney = shopingmoney / 2m;
                        purchases++;
                    }
                    else if (action == '*')
                    {
                        shopingmoney += 10;
                    }
                    else
                    {
                        decimal price = action;
                        if (shopingmoney < price)
                        {
                            continue;
                        }

                        shopingmoney -= price;
                        purchases++;
                    }
                }
                command = Console.ReadLine();
            }


            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", shopingmoney);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", purchases, shopingmoney);
            }

        }

    }


}
