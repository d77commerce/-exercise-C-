using System;

namespace _100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            int nom = int.Parse(Console.ReadLine());
            
            if (nom <= 99)
            {
                Console.WriteLine("Less than 100");
            }
            else if (nom <= 199 )
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (nom >= 200)
            {
                Console.WriteLine("Greater than 200 ");

            }
        }
    }
}
