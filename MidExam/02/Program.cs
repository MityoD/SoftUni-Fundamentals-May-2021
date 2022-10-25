using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toBuy = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "No More Money")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "OutOfStock")
                {
                    string outOfStock = commandArgs[1];
                    for (int i = 0; i < toBuy.Count; i++)
                    {
                        if (toBuy[i] == outOfStock)
                        {
                            toBuy[i] = "None";
                        }
                    }
                }
                else if (action == "Required")
                {
                    string newBuiscuit = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    if (index >= 0 && index < toBuy.Count && toBuy[index] != "None")
                    {
                        toBuy[index] = newBuiscuit;
                    }
                }
                else if (action == "Last")
                {
                    toBuy.Add(commandArgs[1]);
                }
            }
            toBuy.RemoveAll(x => x == "None");
            Console.WriteLine(string.Join(" ",toBuy));
        }
    }
}
