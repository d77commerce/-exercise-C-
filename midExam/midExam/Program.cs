using System;
using System.Collections.Generic;
using System.Linq;

namespace midExam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inPut = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string commands = Console.ReadLine();
            while (commands != "Finish")
            {
                string[] commArray = commands.Split();
                string action = commArray[0];
                int value = int.Parse(commArray[1]);
                if (action == "Add")
                {
                    inPut.Add(value);
                }
                else if (action == "Remove")
                {
                    if (inPut.Contains(value))
                    {
                        inPut.Remove(value);
                    }
                }
                else if(action=="Replace")
                {
                    if (inPut.Contains(value))
                    {
                        int newInt = int.Parse( commArray[2]);
                        int oldInt = inPut.IndexOf(value);
                        inPut.Remove(value);
                        inPut.Insert(oldInt, newInt);
                    }
                }
                else if (action == "Collapse")
                {
                    for (int i = 0; i < inPut.Count; i++)
                    {
                        
                        if (value > inPut[i])
                        {
                            inPut.Remove(inPut[i]);
                           
                        }
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",inPut));
        }
    }
}
