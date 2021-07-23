using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsAges = new int[5];
            studentsAges[0] = 13;
            studentsAges[1] = 32;
            studentsAges[2] = 20;
            studentsAges[3] = 4;
            studentsAges[4] = 87;
            Console.WriteLine($"studen age [0] ={studentsAges[0]}" );
            Console.WriteLine($"studen age [1] ={studentsAges[1]}" );
            Console.WriteLine($"studen age [2] ={studentsAges[2]}" );
            Console.WriteLine($"studen age [3] ={studentsAges[3]}" );
            Console.WriteLine($"studen age [4] ={studentsAges[4]}" );
            Console.WriteLine();
            Console.WriteLine($"total ages is : { studentsAges[0]+studentsAges[1]+studentsAges[2]}");

        }
    }
}
