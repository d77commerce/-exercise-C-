using System;

namespace bollX
{
    class Program
    {
        static void Main(string[] args)
        {
            int xBoll = int.Parse(Console.ReadLine());
            int total = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int odercolor = 0;

            for (int i = 0; i < xBoll; i++)
            {
                string colorBoll = Console.ReadLine();
                switch (colorBoll)
                {
                    case "red":
                        total += 5;
                        red++;
                        break;
                    case "orange":
                        orange++;
                        total += 10;
                        break;
                    case "yellow":
                        yellow++;
                        total += 15;
                        break;
                    case "white":
                        white++;
                        total += 20;
                        break;
                    case "black":
                        black++;
                        total /= 2;
                        break;
                    default:
                        odercolor++;
                        break;



                }

            }
            Console.WriteLine($"Total points: { total}");

            Console.WriteLine($"Points from red balls: {red}");
            Console.WriteLine($"Points from orange balls: {orange}");

            Console.WriteLine($"Points from yellow balls: {yellow}");

            Console.WriteLine($"Points from white balls: {white}");

            Console.WriteLine($"Other colors picked: {odercolor}");

            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
