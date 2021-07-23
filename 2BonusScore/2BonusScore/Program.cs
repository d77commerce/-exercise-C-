using System;

namespace _2BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {

            //⦁	Ако числото е до 100 включително, бонус точките са 5.
            //⦁	Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            //⦁	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.
            int nom = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (nom <= 100)
            {
                bonus += 5;
            }
            else if (nom > 1000)
            {
                bonus += nom * 0.10;

            }
            else
            {
                bonus += nom * 0.20;
            }
            if (nom % 2 == 0)
            {
                bonus += 1;
            }
            else if (nom % 5 == 0)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(nom +bonus);
        }
    }
}
