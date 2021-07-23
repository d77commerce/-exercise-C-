using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = int.Parse(Console.ReadLine());
            int nom = 1;
            while(nom<= x)
            {
                Console.WriteLine(nom);
                nom = nom * 2 + 1;
            }
        }
    }
}
