using System;

namespace apartmen
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int freeSpase = x * y * z;
            int boxIn = 0;
            string inTo = Console.ReadLine();

            while (inTo != "Done")
            {
                int box = int.Parse(inTo);

                boxIn += box;
                if (boxIn >= freeSpase)
                {
                    Console.WriteLine($"No more free space! You need {boxIn-freeSpase} Cubic meters more.");
                    return;
                }
                 inTo = Console.ReadLine();
            }

            Console.WriteLine($" {freeSpase - boxIn} Cubic meters left.");

        }
    }
}
