using System;

namespace dayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = new string[7];
            dayOfWeek[0] = "Monday";
            dayOfWeek[1] = "Tuesday";
            dayOfWeek[2] = "Wednesday";
            dayOfWeek[3] = "Thursday";
            dayOfWeek[4] = "Friday";
            dayOfWeek[5] = "Saturday";
            dayOfWeek[6] = "Sunday";

            int day = int.Parse(Console.ReadLine());
            if (day > 0 && day < 8)
            {
                Console.WriteLine(dayOfWeek[day-1]);
            }
            else
            {
                Console.WriteLine($"Invalid day!");
            }
        }
    }
}
