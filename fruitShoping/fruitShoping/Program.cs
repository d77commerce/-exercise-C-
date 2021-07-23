using System;

namespace fruitShoping
{
    class Program
    {
        static void Main(string[] args)
        {
            //цената на малините е на половина по - ниска от тази на ягодите;
            // цената на портокалите е с 40 % по - ниска от цената на малините;
            // цената на бананите е с 80 % по - ниска от цената на малините.

            // input

            // 1.Цена на ягодите в лева – реално число в интервала[0.00 … 10000.00]
            //2.Количество на бананите в килограми – реално число в интервала[0.00 … 1 0000.00]
            //3.Количество на портокалите в килограми – реално число в интервала[0.00 … 10000.00]
            //4.Количество на малините в килограми – реално число в интервала[0.00 … 10000.00]
            //5.Количество на ягодите в килограми – реално число в интервала[0.00 … 10000.00]

            double priceStroubrry = double.Parse(Console.ReadLine());
            double bannanaKg = double.Parse(Console.ReadLine());
            double oringeKg = double.Parse(Console.ReadLine());
            double roseberyKg = double.Parse(Console.ReadLine());
            double strouberyKg = double.Parse(Console.ReadLine());

            double priceRosebery = priceStroubrry * 0.5;
            double priceOringe = priceRosebery * 0.60;
            double priceBannana = priceRosebery * 0.20;

            double sumStroubery = priceStroubrry * strouberyKg;
            double sumBannana = bannanaKg * priceBannana;
            double sunOringe = oringeKg * priceOringe;
            double sumRosebery = priceRosebery * roseberyKg;

            double sumtotal = sunOringe + sumBannana + sumRosebery + sumStroubery;
            Console.WriteLine("{0:f2}", sumtotal);
                  


        }
    }
}

