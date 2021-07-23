using System;

namespace cinemd
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int saleTikets = 0;
            int studentTikets = 0;
            int standartTikets = 0;
            int kidTikets = 0;
            double totoalTiket = 0;

            while (film != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                string taypeTiket = (Console.ReadLine());

                while (taypeTiket != "End")
                {

                    if (taypeTiket == "student")
                    {
                        studentTikets++;

                    }
                    else if (taypeTiket == "standard")
                    {

                        standartTikets++;
                    }
                    else if (taypeTiket == "kid")
                    {

                        kidTikets++;
                    }
                    saleTikets++;

                    if (freeSeats == saleTikets)
                    {
                        break;
                    }
                    taypeTiket = Console.ReadLine();

                }
                totoalTiket += saleTikets;
                Console.WriteLine($"{film} - {saleTikets * 1.00 / freeSeats * 100:f2}% full."
);
                saleTikets = 0;
                film = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totoalTiket}");
            Console.WriteLine($"{studentTikets * 1.00 / totoalTiket * 100:f2}% student tickets.");
            Console.WriteLine($"{standartTikets * 1.00 / totoalTiket * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTikets * 1.00 / totoalTiket * 100:f2}% kids tickets.");
        }
    }
}
