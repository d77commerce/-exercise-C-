using System;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            double cnv = change * 100;
            int coins = (int)cnv;
            int x = 0;

            while (coins > 0)
            {
                if (coins - 200 >= 0)
                {
                    x++;
                    coins -= 200;
                }
                 else if (coins - 100 >= 0)
                {
                    x++;
                    coins -= 100;
                }
                else if (coins - 50 >= 0)
                {
                    x++;
                    coins -= 50;
                }
                else if (coins - 20 >= 0)
                {
                    x++;
                    coins -= 20;
                }
                else if (coins - 10 >= 0)
                {
                    x++;
                    coins -= 10;
                }
                else if (coins - 5 >= 0)
                {
                    x++;
                    coins -= 5;
                }
                else if (coins - 2 >= 0)
                {
                    x++;
                    coins -= 2;
                }
                else if (coins - 1 >= 0)
                {
                    x++;
                    coins -= 1;
                }
            }
            Console.WriteLine(x);
        }
    }
}
