using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inPut = Console.ReadLine()
                 .Split("!").
                 ToList();
            string comand = Console.ReadLine();

            while (comand != "Go Shopping!")
            {
                string[] comArray = comand.Split(" ").ToArray();

                if (comArray[0] == "Urgent")
                {
                    if (!inPut.Contains(comArray[1]))
                    {
                        inPut.Remove(comArray[1]);
                        inPut.Insert(0, comArray[1]);
                    }

                }
                else if (comArray[0] == "Unnecessary")
                {
                    if (inPut.Contains(comArray[1]))
                    {
                        inPut.Remove(comArray[1]);
                    }
                }
                else if (comArray[0] == "Correct")
                {
                    int old = inPut.IndexOf(comArray[1]);

                    if (inPut.Contains(comArray[1]))
                    {
                        inPut.Insert(old, comArray[2]);
                        inPut.Remove(comArray[1]);
                    }
                }

                else if (comArray[0] == "Rearrange")
                {
                    if (inPut.Remove(comArray[1]))
                    {
                        inPut.Add(comArray[1]);
                    }
                }
                    
              
                comand = Console.ReadLine();
            }
Console.WriteLine(string.Join(", ", inPut));
        }
    }

}