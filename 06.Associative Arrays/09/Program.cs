using System;
using System.Collections.Generic;
using System.Linq;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceDB = new Dictionary<string, List<string>>();
            string command = "";
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandInfo.Contains("|"))
                {
                    string[] commandArgs = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = commandArgs[0];
                    string forceUser = commandArgs[1];
                    if (!forceDB.ContainsKey(forceSide))
                    {
                        forceDB.Add(forceSide, new List<string>());
                    }
                    if (!forceDB[forceSide].Contains(forceUser))
                    {
                        forceDB[forceSide].Add(forceUser);
                    }
                }
                else if (commandInfo.Contains("->"))
                {
                    string[] commandArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = commandArgs[0];
                    string forceSide = commandArgs[1];                    
                    foreach (var item in forceDB)
                    {
                        if (item.Value.Contains(forceUser))
                        {
                            item.Value.Remove(forceUser);
                        }
                    }                  
                    if (!forceDB.ContainsKey(forceSide))
                    {
                        forceDB.Add(forceSide, new List<string>());
                    }
                    forceDB[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

            }

            foreach (var item in forceDB.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    foreach (var users in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {users}");
                    }
                }

            }
        }
    }
}
