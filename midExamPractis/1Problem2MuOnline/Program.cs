using System;
using System.Collections.Generic;

namespace _1Problem2MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                  .Split("|");
            int helt = 100;
            int coin = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] act = input[i].Split(" ");
                string comand = act[0];
                int num = int.Parse(act[1]);


                switch (comand)
                {
                    case "potion":
                        helt += num;
                        if (helt > 100)
                        {

                            int heltPlus = helt - 100;
                            int heltInt = num - heltPlus;
                            Console.WriteLine($"You healed for {heltInt} hp.");

                            helt = 100;
                            Console.WriteLine($"Current health: {helt} hp.");
                        }

                        else
                        {
                            Console.WriteLine($"You healed for {num} hp.");
                            Console.WriteLine($"Current health: {helt} hp.");
                        }

                        break;
                    case "chest":
                        coin += num;
                        Console.WriteLine($"You found {num} bitcoins.");
                        break;
                    default:
                        helt -= num;
                        if (helt <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {comand}.");
                            Console.WriteLine($"Best room: {i+ 1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {comand}.");
                        }

                        break;

                }

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {coin}");
            Console.WriteLine($"Health: {helt}");
        }
    }
}
