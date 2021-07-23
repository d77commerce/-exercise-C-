using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string xin = Console.ReadLine();
            int maxNom = int.MinValue;


            while (xin != "Stop")

            {
                int chage = int.Parse(xin);
                if (chage > maxNom)
                {
                    maxNom = chage;
                }

            }
            Console.WriteLine(maxNom);

        }
        
    }
}
