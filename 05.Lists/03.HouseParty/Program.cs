using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsNum = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < commandsNum; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                string action = commandArgs[2];
                if (action == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                if (action == "not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
            
        }
    }
}

