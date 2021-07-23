using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int bad = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            int gradNom = int.Parse(Console.ReadLine());
            string lastProblem = "";
            int badPoint = 0;
            double gradtotal = gradNom;
            int canting = 0;


            while (true)
            {
                canting++;
              

                if (gradNom <= 4)
                {
                    badPoint++;


                }
                if (badPoint == bad)
                {
                    Console.WriteLine($"You need a break, {bad} poor grades.");
                   return;
                }
                problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    break;
                }
                gradNom = int.Parse(Console.ReadLine());
                gradtotal += gradNom;
                lastProblem = problem;



            }
            Console.WriteLine($"Average score: {gradtotal / canting:f2}");
            Console.WriteLine($"Number of problems: {canting}");
            Console.WriteLine($"Last problem: {lastProblem}");


        }
    }
}
