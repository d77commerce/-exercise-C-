using System;

namespace readText
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string x = Console.ReadLine();
            while(x != password)
            {
               
                x = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
