using System;

namespace _05Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int totalH = 0;
            int totalM = m + 15;
            totalH = totalM / 60;
            if (totalH + h >= 24)
            {
                Console.WriteLine($"0:{totalM % 60:d2}");

            }
            else
            {
                Console.WriteLine($" {h + totalH}:{totalM % 60:d2}");
            }
        }
    }
}
