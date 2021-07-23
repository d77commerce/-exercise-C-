using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string book = Console.ReadLine();
            int nomBook = 0;

            while (book != "No More Books")
            {
                
                if (book == x)
                {
                    Console.WriteLine($"You checked {nomBook} books and found it.");
                    return;
                }
                nomBook++;
                book = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!"
);
            Console.WriteLine($"You checked {nomBook} books.");

        }
    }
}
