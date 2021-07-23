using System;

namespace password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = (Console.ReadLine());
            if (password == "qwerty")
            {
                Console.WriteLine("Wrong password!");
            }
            else if (password == "s3cr3t!P@ssw0rd") 

            {
                Console.WriteLine("Welcome");

            }
          
            else if (password == "s3cr3t!p@ss")
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
