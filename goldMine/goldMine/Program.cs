using System;

namespace goldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int location = int.Parse(Console.ReadLine());
            
            int totalDays = 0;
            for (int i = 0; i < location; i++)
            {
                double localTotalGold = 0;

                int targetGold = int.Parse(Console.ReadLine());

                int dayInLocation = int.Parse(Console.ReadLine());
                for (int j = 0; j < dayInLocation; j++)
                {
                    int dayGold = int.Parse(Console.ReadLine());
                    
                    localTotalGold += dayGold;
                    dayGold = 0;
                }
                double x = localTotalGold / dayInLocation;

                    if (targetGold <=x)
                    {

                        Console.WriteLine($"Good job! Average gold per day: {localTotalGold *1.00/ dayInLocation:f2}.");
                    }
                    else
                    {
                        Console.WriteLine($"You need {targetGold-x:f2} gold.");
                    }


                
            }
        }
    }
}
