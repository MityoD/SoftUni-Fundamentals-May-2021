using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Trains
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandArgs[0] == "Add")
                {
                    int newWagons = int.Parse(commandArgs[1]);
                    wagons.Add(newWagons);                   
                   
                }
                else
                {
                    int newPassengers = int.Parse(commandArgs[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= capacity)
                        {
                            wagons[i] += newPassengers;                            
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
