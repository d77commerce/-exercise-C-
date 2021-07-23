using System;
using System.Collections.Generic;

namespace _05carpark
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] inPut = Console.ReadLine().Split();
                string comand = inPut[0];
                string name = inPut[1];
               
                if(comand == "register")
                {
                    if (!users.ContainsKey(name)) 
                    {
                        users.Add(name, inPut[2]);
                        Console.WriteLine($"{name} registered {inPut[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {inPut[2]}");
                    }

                }
                else
                {
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        users.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
