using System;

namespace invalidNom
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x != 0 && x < 100 || x > 200)
            {
                Console.WriteLine("invalid");
            }
           

        }
    }
}
