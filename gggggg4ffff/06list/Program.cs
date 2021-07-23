using System;
using System.Collections.Generic;
using System.Linq;

namespace _06list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nom = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string act = Console.ReadLine();

            while (act != "end")
            {
                string[] transf = act.Split();
                string toDo = transf[0];
                int inNum = int.Parse(transf[1]);

                if (toDo == "Add")
                {
                    nom.Add(inNum);
                }
                else if (toDo == "Remove")
                {
                    nom.Remove(inNum);
                }
                else if (toDo == "RemoveAt")
                {
                    nom.RemoveAt(inNum);
                }
                else if (toDo == "Insert")
                {
                    int inNum2 = int.Parse(transf[2]);
                    nom.Insert(inNum2, inNum);
                }

                act = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nom));
        }
    }
}
