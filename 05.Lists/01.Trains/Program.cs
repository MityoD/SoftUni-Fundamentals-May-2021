using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            /* You will receive a list of wagons (integers) on the first line. Every integer represents the number of passengers that are currently in each of the wagons. On the next line, you will get the max capacity of each wagon (a single integer). Until you receive "end" you will be given two types of input:
	•	Add {passengers} – add a wagon to the end with the given number of passengers.
	•	{passengers} - find an existing wagon to fit every passenger, starting from the first wagon.
At the end print the final state of the train (each of the wagons, separated by a space).*/
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();
                if (commandArgs[0] == "Add")
                {
                    int newWagons = int.Parse(commandArgs[1]);
                    wagons.Add(newWagons);
                }
                else
                {
                    int newPassengers = int.Parse(commandArgs[0]);
                    for (int i = 0; i <wagons.Count; i++)
                    {
                        if (wagons[i] + newPassengers <= capacity)
                        {
                            wagons[i] += newPassengers;
                        }
                    }
                }
                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
