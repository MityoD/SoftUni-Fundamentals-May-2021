using System;
using System.Collections.Generic;
using System.Linq;

namespace _0303.MovingTarger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                int index = int.Parse(commandArgs[1]);
                if (commandArgs[0] == "Shoot")
                {                  
                    int power = int.Parse(commandArgs[2]);
                    if (index < targets.Count)
                    {
                        if (targets[index] > 0)
                        {
                            targets[index] -= power;
                        }
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commandArgs[0] == "Add") 
                {
                                       int value = int.Parse(commandArgs[2]);
                    if (index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (commandArgs[0] == "Strike")
                {
                   
                    int radius = int.Parse(commandArgs[2]);
                    
                    if (index >= radius && index < targets.Count - radius)
                    {
                        for (int i = index - radius; i <= index + radius; i++)
                        {
                            targets[i] = -1;
                        }
                        targets.RemoveAll(x => x == -1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                if (targets.Count == 0)
                {
                    return;
                }
            }
            if (targets.Count > 0)
            {
            Console.WriteLine(string.Join("|", targets));

            }
        }
    }
}
