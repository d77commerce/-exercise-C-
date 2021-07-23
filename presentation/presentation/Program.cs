using System;

namespace presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int juNom = int.Parse(Console.ReadLine());
            string proj = Console.ReadLine();
            double totalX = 0;
            double x = 0;
            int totalJuj = 0;

            while (proj != "Finish")
            {
                for (int i = 0; i < juNom; i++)
                {
                    x += double.Parse(Console.ReadLine());
                }
                totalX += x;
                totalJuj += juNom;
                Console.WriteLine($"{proj} - {x / juNom:f2}.");
                x = 0;
                proj = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalX / totalJuj:f2}.");
        }
    }
}
