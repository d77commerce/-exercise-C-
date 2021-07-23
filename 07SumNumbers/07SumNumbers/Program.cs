using System;

namespace _07SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int nom = int.Parse(Console.ReadLine());
                
                if (nom < min)
                {
                     min = nom;
                }
                if (nom > max)
                {
                    max = nom;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
           
        }

    }
       
}
