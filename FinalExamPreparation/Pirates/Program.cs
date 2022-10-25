using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> cities = new Dictionary<string, int[]>();
            string command = "";
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] commandArgs = command.Split("||");
                string city = commandArgs[0];
                int people = int.Parse(commandArgs[1]);
                int gold = int.Parse(commandArgs[2]);
                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, new int[2]);
                }
                cities[city][0] += people;
                cities[city][1] += gold;
            }
            string command2 = "";
            while ((command2 = Console.ReadLine()) != "End")
            {
                string[] command2Args = command2.Split("=>");
                string action = command2Args[0];
                string location = command2Args[1];
                if (action == "Plunder")
                {
                    int people = int.Parse(command2Args[2]);
                    int gold = int.Parse(command2Args[3]);
                    Console.WriteLine($"{location} plundered! {gold} gold stolen, {people} citizens killed.");
                    cities[location][0] -= people;
                    cities[location][1] -= gold;
                    if (cities[location][0] <= 0 || cities[location][1] <= 0)
                    {
                        cities.Remove(location);
                        Console.WriteLine($"{location} has been wiped off the map!");
                    }
                }
                else if (action == "Prosper")
                {
                    int gold = int.Parse(command2Args[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    cities[location][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {location} now has {cities[location][1]} gold.");
                }
            }
            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
        }
    }
}
