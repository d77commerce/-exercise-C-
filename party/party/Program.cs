using System;

namespace party
{
    class Program
    {
        static void Main(string[] args)
        {
            //  • Торта – цената ѝ е 20 % от наема на залата
            //• Напитки – цената им е 45 % по - малко от тази на тортата
            //• Аниматор – цената му е 1 / 3 от цената за наема на залата
            double rent = double.Parse(Console.ReadLine());
            double cacke = rent * 0.20;
            double drink = cacke - cacke * 0.45;
            double animator = rent / 3;

                Console.WriteLine(rent + cacke + drink + animator);
        }
    }
}
