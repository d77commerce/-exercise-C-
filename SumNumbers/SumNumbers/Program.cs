using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int nom = int.Parse(Console.ReadLine());

            while(nom < x)
            {
                int newNom = int.Parse(Console.ReadLine());
                nom += newNom;
            }
            Console.WriteLine(nom);
        }
    }
}
