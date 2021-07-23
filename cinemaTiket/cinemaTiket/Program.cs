using System;

namespace cinemaTiket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            int Tiket = 0;

            switch (day)
            {
                case ("Monday"):
                    Tiket = 12;
                    break;
                case ("Tuesday"):
                    Tiket = 12;
                    break;
                case ("Wednesday"):
                    Tiket = 14;
                    break;
                case ("Thursday"):
                    Tiket = 14;
                    break;
                case ("Friday"):
                    Tiket = 12;
                    break;
                case ("Saturday"):
                    Tiket = 16;
                    break;
                case ("Sunday"):
                    Tiket = 16;
                    break;
            }
            Console.WriteLine(Tiket);  
        }
    }
}
