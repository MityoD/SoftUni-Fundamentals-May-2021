using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        { //0 - health 
            //1 - energy
            Dictionary<string, int[]> people = new Dictionary<string, int[]>();
            string command = "";
            while ((command = Console.ReadLine())!= "Results")
            {
                string[] commandArgs = command.Split(":");
                string action = commandArgs[0];
                if (action == "Add")
                {
                    string name = commandArgs[1];
                    int health = int.Parse(commandArgs[2]);
                    int energy = int.Parse(commandArgs[3]);
                    if (!people.ContainsKey(name))
                    {
                        people.Add(name, new int[2]);
                        people[name][0] = health;
                        people[name][1] = energy;
                    }
                    else
                    {
                        people[name][0] += health;
                    }
                }
                else if (action == "Attack")
                {
                    string attackerName = commandArgs[1];
                    string defenderName = commandArgs[2];
                    int damage = int.Parse(commandArgs[3]);
                    if (people.ContainsKey(attackerName) && people.ContainsKey(defenderName))
                    {
                        people[defenderName][0] -= damage;
                        people[attackerName][1] -= 1;
                        if (people[defenderName][0] <= 0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            people.Remove(defenderName);
                        }
                        if (people[attackerName][1] <= 0)
                        {
                            Console.WriteLine($"{attackerName} was disqualified!");
                            people.Remove(attackerName);
                        }
                    }
                }
                else if (action == "Delete")
                {
                    string toDelete = commandArgs[1];
                    if (toDelete == "All")
                    {
                        foreach (var item in people)
                        {
                            people.Remove(item.Key);
                        }
                    }
                    else
                    {
                        people.Remove(toDelete);
                    }
                }
            }
            Console.WriteLine($"People count: {people.Count}");
            foreach (var item in people.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} - {item.Value[1]}");
            }
           
        }
    }
}
