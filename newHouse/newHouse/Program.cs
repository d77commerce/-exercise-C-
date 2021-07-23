using System;

namespace newHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //            цвете           Роза       Далия  Лале    Нарцис  Гладиола
            //        Цена на брой в лева   5    3.80       2.80      3      2.50
           

            //                   ⦁	Вид цветя -текст с възможности -"", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //⦁               	Брой цветя -цяло число в интервала[10…1000]
            //⦁         	Бюджет - цяло число в интервала[50…2500]
            string type = Console.ReadLine();
            int mach = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());
            double spendet = 0.0;

            switch (type)
            {
                case "Roses":
                    if (mach > 80)
                    {
                        spendet -= mach * 5.00 * 0.10;
                    }
                    spendet += mach * 5.00;

                    break;
                case "Dahlias":
                    if (mach > 90)
                    {
                        spendet -= mach * 3.80 * 0.15;
                    }
                    spendet += mach * 3.80;
                    break;
                case "Tulips":
                    if (mach > 80)
                    {
                        spendet -= mach * 2.80;
                    }
                    spendet += mach * 2.80;
                    
                    break;
                case "Narcissus":
                    if (mach<120)
                    {
                        spendet += mach * 3.00 * 0.15;
                    }
                    spendet += mach * 3.00;
                    break;
                case "Gladiolus":
                    if (mach < 80)
                    {
                        spendet += mach * 2.50 * 0.20;
                    }
                    spendet += mach * 2.5;
                    break;

            }
            if (money >= spendet)
            {
                double moneyLeft = money - spendet;
                Console.WriteLine($"Hey, you have a great garden with {mach} {type} and {moneyLeft:f2} leva left.");
            }
            else 
            {
                double need = spendet - money;
                Console.WriteLine($"Not enough money, you need {need:f2} leva more.");

            }
        }
    }
}
