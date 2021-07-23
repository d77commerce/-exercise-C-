using System;

namespace building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());

            for (int i = floor; i > 0; i--)

            {
                Console.WriteLine();
                for (int x = 0; x < room; x++)
                {
                    if(i==floor)
                    {
                        Console.Write($"L{i}{x}");
                        Console.Write(" ");
                        continue;
                    }
                    if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{x}");
                    }
                    else
                    {
                        Console.Write($"A{i}{x}");
                    }
                    Console.Write(" ");
                }
            }

        }
    }
}
