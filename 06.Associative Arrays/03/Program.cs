using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var keyMaterials = new Dictionary<string, int>
            { 
                ["shards"]= 0,
                ["fragments"]= 0,
                ["motes"]= 0,                
            };
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            int qty = 0;
            string obtainedItem = "";
            bool itemFound = true;
            while (itemFound)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        qty = int.Parse(input[i]);
                    }
                    else
                    {
                        string material = input[i].ToLower();
                        if (material == "shards" || material == "fragments" || material == "motes")
                        {                            
                            keyMaterials[material] += qty;
                        }                        
                        else
                        {
                            if (!junkMaterials.ContainsKey(material))
                            {
                                junkMaterials.Add(material, 0);
                            }
                            junkMaterials[material] += qty;
                        }
                    }
                    foreach (var items in keyMaterials)
                    {
                        if (items.Value >= 250)
                        {
                            obtainedItem = items.Key;
                            itemFound = false;
                            keyMaterials[items.Key] -= 250;
                            break;
                        }
                    }
                    if (!itemFound)
                    {
                        break;
                    }

                }
                if (itemFound)
                {
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                }
            }
            string legendaryItem = "";
            switch (obtainedItem)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;
                case "fragments":
                    legendaryItem = "Valanyr";
                    break;
                case "motes":
                    legendaryItem ="Dragonwrath";
                    break;
            }
            
            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var (item, num) in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item}: {num}");
            }
            foreach (var (item, num) in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item}: {num}");
            }
            
        }
    }
}
