using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int totalSteps = 0;

            while (steps != "Going home")
            {

                int xsteps = int.Parse(steps);
                totalSteps += xsteps;


                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
                    return;
                }
                steps = Console.ReadLine();
            }
            int y = int.Parse(Console.ReadLine());
            totalSteps += y;

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }
            else
            {
                int s = 10000 - totalSteps;
                Console.WriteLine($"{s} more steps to reach goal.");
            }


        }
    }
}
