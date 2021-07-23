using System;

namespace _44444444
{
    class Program
    {
        static void Main(string[] args)
        {
            string xin = Console.ReadLine();
            int minNom = int.MaxValue;


            while (xin != "Stop")

            {
                int chage = int.Parse(xin);
                if (minNom >chage)
                {
                    minNom = chage;
                }
                xin = Console.ReadLine();
            }
            Console.WriteLine(minNom);
        }
    }
}
