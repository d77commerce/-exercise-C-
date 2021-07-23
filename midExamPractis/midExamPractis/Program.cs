using System;

namespace midExamPractis
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = int.Parse(Console.ReadLine());
            double lecturs = int.Parse(Console.ReadLine());
            double bonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAtendsOfStudent = 0;

            for (int i = 0; i < students; i++)
            {
                double atedesOfStudent = double.Parse(Console.ReadLine());
                if (atedesOfStudent>maxAtendsOfStudent)
                {
                    maxAtendsOfStudent = atedesOfStudent;
                }
               double calculateBonus = atedesOfStudent / lecturs*(5 + bonus);
                if (calculateBonus > maxBonus)
                {
                    maxBonus = calculateBonus;
                }

            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling( maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAtendsOfStudent} lectures.");
        }
    }
}
