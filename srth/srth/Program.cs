using System;

namespace srth
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination !="End")
            {
                double budget = double.Parse(Console.ReadLine());
                double sumPlus = 0;
                while (sumPlus < budget)
                {
                    sumPlus += int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();

            }
        }
    }
}
