using System;

namespace fishTanck
{
    class Program
    {
        static void Main(string[] args)
        {
            double aCm = double.Parse(Console.ReadLine());
            double bCm = double.Parse(Console.ReadLine());
            double cCm = double.Parse(Console.ReadLine());
            double procentSend = double.Parse(Console.ReadLine());

            double volume = aCm * bCm * cCm;
            double liters = volume * 0.001;
            double prosentOfSendTotal = procentSend * 0.01;
            double totalLiter = liters *(1 -  prosentOfSendTotal);
            Console.WriteLine(totalLiter);

        }
    }
}
