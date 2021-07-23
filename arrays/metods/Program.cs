using System;

namespace metods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            test(x, d);
        }

        private static void test(int one, int second)
        {
            int kaka = one * second;
            Console.WriteLine(kaka);
        }
    }
}
