using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> newDeck = new List<string>();
            string command = "";
            while ((command = Console.ReadLine())!="Ready")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "Add")
                {
                    string newCard = commandArgs[1];
                    if (deck.Contains(newCard))
                    {
                        newDeck.Add(newCard);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (action == "Insert")
                {
                    string newCard = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);
                    if (deck.Contains(newCard) && index >= 0 && index < newDeck.Count)
                    {
                        newDeck.Insert(index, newCard);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (action == "Remove")
                {
                    string newCard = commandArgs[1];
                    if (newDeck.Contains(newCard))
                    {
                        newDeck.Remove(newCard);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (action == "Swap")
                {
                    string newCard1 = commandArgs[1];
                    string newCard2 = commandArgs[2];                    
                    int firstCardIndex = newDeck.IndexOf(newCard1);
                    int secondCardIndex = newDeck.IndexOf(newCard2);
                    newDeck[firstCardIndex] = newCard2;
                    newDeck[secondCardIndex] = newCard1;
                }
                else if (action == "Shuffle")
                {
                    newDeck.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ",newDeck));
        }
    }
}
