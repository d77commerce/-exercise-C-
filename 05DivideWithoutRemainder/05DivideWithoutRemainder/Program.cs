using System;

namespace _05DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x2 = 0;
            int x3 = 0;
            int x4 = 0;

            for (int i = 0; i < n; i++)
            {
               int x = int.Parse(Console.ReadLine());
              if (x % 2 == 0)
                {
                    x2++;
                }
                if (x % 3 == 0)
                {
                    x3++;
                }
                if (x % 4 == 0)
                {
                    x4++;
                }



            }
            double xz2 = x2*1.0 / n  * 100.00;
            double xz3 = x3*1.0 / n  * 100.00;
            double xz4 = x4*1.0 / n  * 100.00;
            Console.WriteLine($"{xz2:f2}%");
            Console.WriteLine($"{xz3:f2}%");
            Console.WriteLine($"{xz4:f2}%");
        }
    }
}
