using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventori = Console.ReadLine()
                 .Split(", ").ToList();
            string comand = Console.ReadLine();
            while (comand != "Craft!")
            {
                string[] comandAr = comand.Split(" - ");
                string oneComand = comandAr[0];
                string item = comandAr[1];


                if (oneComand == "Collect")
                {
                    inventori.Add(item);

                }

                if (oneComand == "Drop")
                {


                    inventori.Remove(item);

                }
                if (oneComand == "Combine Items")
                {

                    string[] combineItems = item.Split(":");
                    int indexOld = inventori.IndexOf(combineItems[0]);
                    if (indexOld >= 0)
                    {
                        inventori.Insert(indexOld + 1, combineItems[1]);
                    }

                }
                if (oneComand == "Renew")
                {


                    if (inventori.Remove(item))
                    {
                        inventori.Add(item);
                    }

                }
                comand = Console.ReadLine();
            }


            Console.WriteLine(string.Join(", ", inventori));
        }
    }
}

