using System;

namespace _06GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double mony = double.Parse(Console.ReadLine());
            int man = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decor = mony * 0.10;
            double totalClotes = man * priceClothes;
            double total = 0;
            if (man >= 150)
            {
                totalClotes *= 0.90;

                total = decor + totalClotes;

            }
            else
            {

                total = decor + totalClotes;
            }
            if (total > mony)
            {
                double need = total - mony;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {need:f2} leva more.");
            }
            else
            {
                double left = mony - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");



            }



        }

    }
}
