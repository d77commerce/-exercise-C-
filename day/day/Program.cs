using System;

namespace day
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            int x = 0;
            if (h >= 10 && h <= 18)
            {
                switch (day)
                {
                    case ("Monday"):
                        x++;
                        break;
                    case ("Tuesday"):
                        x++;
                        break;
                    case ("Wednesday"):
                        x++;
                        break;
                    case ("Thursday"):
                        x++;
                        break;
                    case ("Friday"):
                        x++;
                        break;
                    case ("Saturday"):
                        x++;
                        break;
                        x++;
                    case ("Sanday"):
                        break;

                }
                if (x == 1)
                {
                    Console.WriteLine("open");
                    return;
                }
            }
            Console.WriteLine("closed");
        }
    }
}
