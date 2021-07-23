using System;

namespace air
{
    class Program
    {
        static void Main(string[] args)
        {
            string airCompany = Console.ReadLine();
            int xTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double kidtiketPrice = ticketPrice * 0.30;

            double totalXtickets = (xTickets * ticketPrice) + (xTickets * tax);
            double totalKidTickets = (kidTickets * kidtiketPrice) + (kidTickets * tax);
            Console.WriteLine($"The profit of your agency from {airCompany} tickets is {(totalXtickets + totalKidTickets) * 0.20:f2} lv.");

        }
    }
}
