using System;

namespace _110621_1
{
    class Program
    {
        private static bool f;

        static void Main(string[] args)
        {
          

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            print(x, y, v);




        }

        private static void print(int x, int y, int v)
        {
            if (x < y&& x < v)
            {
                Console.WriteLine(x);
            }
            else if (y < v)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine(v);
            }
        }
    }
}
