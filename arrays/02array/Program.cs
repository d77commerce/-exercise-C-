using System;

namespace _02array
{
    class Program
    {
        static void Main(string[] args)
        {
            string  [] one = Console.ReadLine().Split(" ");
            string [] second = Console.ReadLine().Split(" ");

            for (int i = 0; i < second.Length; i++)
            {
                string test = second[i];
                for (int x = 0; x < one.Length; x++)
                {
                    if (one[x] == test)
                    {
                        Console.Write(test+ " ");
                    }
                }
            }
        }
    }
}
