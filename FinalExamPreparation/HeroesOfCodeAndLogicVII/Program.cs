using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            for (int i = 0; i < num; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string name = heroInfo[0];
                int HP = int.Parse(heroInfo[1]);
                int MP = int.Parse(heroInfo[2]);
                heroes.Add(name, new int[2]);
                heroes[name][0] = HP;
                heroes[name][1] = MP;
            }
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" - ");
                string action = commandArgs[0];
                string heroName = commandArgs[1];
                if (action == "CastSpell")
                {
                    int MPNeeded = int.Parse(commandArgs[2]);
                    string spellName = commandArgs[3];

                    if (heroes[heroName][1] >= MPNeeded)
                    {
                        heroes[heroName][1] -= MPNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(commandArgs[2]);
                    string attacker = commandArgs[3];
                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (action == "Recharge")
                {
                    int amount = int.Parse(commandArgs[2]);
                    if (heroes[heroName][1] + amount > 200)
                    {
                        amount = 200 - heroes[heroName][1];                        	
                    }
                    heroes[heroName][1] += amount;
                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (action == "Heal")
                {
                    int amount = int.Parse(commandArgs[2]);
                    if (heroes[heroName][0] + amount > 100)
                    {
                        amount = 100 - heroes[heroName][0];
                    }
                    heroes[heroName][0] += amount;
                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }

            }
            foreach (var item in heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"HP: {item.Value[0]}");
                Console.WriteLine($"MP: {item.Value[1]}");    
            
            }
        }
    }
}
