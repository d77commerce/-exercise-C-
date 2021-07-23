using System;

namespace nomAfter3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nom = int.Parse(Console.ReadLine());


            for (int i = 0; i <= nom; i++)

            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow (2,i));
                }

            }
        }
    }
}
