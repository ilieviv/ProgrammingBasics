using System;

namespace _04._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());

            decimal lv = Math.Floor(money);
            decimal st = (money - lv) * 100;

            int counter = 0;

            while (lv > 0)
            {
                if (lv >= 2)
                {
                    counter++;
                    lv -= 2;
                }
                else if (lv >= 1)
                {
                    counter++;
                    lv -= 1;
                }
            }

            while (st > 0)
            {
                if (st >= 50)
                {
                    st -= 50;
                    counter++;
                }
                else if (st >= 20)
                {
                    st -= 20;
                    counter++;
                }
                else if (st >= 10)
                {
                    st -= 10;
                    counter++;
                }
                else if (st >= 5)
                {
                    st -= 5;
                    counter++;
                }
                else if (st >= 2)
                {
                    st -= 2;
                    counter++;
                }
                else if (st >= 1)
                {
                    st -= 1;
                    counter++;
                    break;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(counter);

        }
    }
}
