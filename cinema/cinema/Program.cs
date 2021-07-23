using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double premiere = 12.00;
            const double pnormal = 7.50;
            const double discount = 5.00;
            string type = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double totalIn = 0.0;

            switch (type)
            {
                case "Premiere":
                    totalIn = a * b * premiere;
                    break;
                case "Normal":
                    totalIn = a * b * pnormal;
                    break;
                case "Discount":
                    totalIn = a * b * discount;
                    break;

            }
            Console.WriteLine($"{totalIn:f2} leva");
        }
    }
}
