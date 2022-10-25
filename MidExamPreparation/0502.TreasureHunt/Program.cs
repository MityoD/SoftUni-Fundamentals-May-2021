using System;
using System.Collections.Generic;
using System.Linq;

namespace _0502.TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<string> chest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "Loot")
                {
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        if (!chest.Contains(commandArgs[i]))
                        {
                            chest.Insert(0, commandArgs[i]);
                        }
                    }
                }
                else if (action == "Drop")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index < 0 || index > chest.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        string temp = chest[index];
                        chest.RemoveAt(index);
                        chest.Add(temp);
                    }
                }
                else if (action == "Steal")
                {
                    int count = int.Parse(commandArgs[1]);
                    if (chest.Count < count)
                    {
                        count = chest.Count;
                    }
                    List<string> stolenItems = new List<string>();
                    int i = chest.Count - 1;
                    while (count > 0)
                        {
                            stolenItems.Add(chest[i]);
                            chest.RemoveAt(i);
                            i--;
                            count--;
                        }
                    stolenItems.Reverse();
                    Console.WriteLine(string.Join(", ", stolenItems));
                }

            }            
            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double averageGain = 0;         
                    
                    //foreach (var item in chest) //NB!!!
                    //{
                    //    averageGain += item.Length;
                    //}
                for (int i = 0; i < chest.Count; i++)
                {
                    averageGain += chest[i].Length;
                }
                Console.WriteLine($"Average treasure gain: {averageGain / chest.Count:F2} pirate credits.");
            }
        }
    }
}
