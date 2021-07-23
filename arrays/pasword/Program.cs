using System;
using System.Linq;

namespace pasword
{
    class Program
    {
        public static int Length { get; private set; }

        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            NewMethod(x);

        }

        private static void NewMethod(string x)
        {



            if (x.Length < 6 || x.Length > 10)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }

            if (!x.All(char.IsLetterOrDigit))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            int cont = 0;
            char[] xd = x.ToCharArray();

            for (int i = 0; i <= xd.Length - 1; i++)
            {
                int rre = xd[i];

                if (rre >= 48 && rre < 58)
                {

                    cont++;
                    if (cont == 2)
                    {
                        Console.WriteLine($"Password is valid");
                        return;
                    }

                   
                }

            }
            if (cont != 2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }
        }
    }
}
