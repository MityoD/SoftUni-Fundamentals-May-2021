using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commandArgs = command.Split();
                if (commandArgs[0] == "Urgent")
                {
                    string item = commandArgs[1];
                    if (list.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        list.Insert(0, item);
                    }
                }
                else if (commandArgs[0] == "Unnecessary")
                {
                    string item = commandArgs[1];
                    if (list.Contains(item))
                    {
                        list.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }                
                else if (commandArgs[0] == "Correct")
                {
                    string oldItem = commandArgs[1];
                    string newItem = commandArgs[2];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == oldItem)
                        {
                            list[i] = newItem;
                        }
                    }
                }
                else if (commandArgs[0] == "Rearrange")
                {
                    string item = commandArgs[1];
                    if (list.Contains(item))
                    {                        
                        list.Remove(item);
                        list.Add(item);
                    }
                }

            }
            Console.WriteLine(string.Join(", ", list));

        }
    }
}
