using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = 1;

            for (int row = 1; row <= x; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(y + " ");
                    y++;
                    if (y > x)
                    {
                        return;
                    }
                }
                    Console.WriteLine();
            }
        }
    }
}
