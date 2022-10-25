using System;
using System.Collections.Generic;
using System.Linq;

namespace _0403.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = "";
            int moves = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                int index1 = int.Parse(commandArgs[0]);
                int index2 = int.Parse(commandArgs[1]);
                if (elements.Count > 0)
                {
                moves++;
                    if (index1 == index2 || index1 < 0 || index2 < 0 || index1 > elements.Count -1 || index2 > elements.Count - 1)
                    {
                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                        int addingIndex = elements.Count / 2;
                        elements.Insert(addingIndex, $"-{moves}a");
                        elements.Insert(addingIndex, $"-{moves}a");
                    }
                    else if (elements[index1] == elements[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                        if (index2 > index1)
                        {
                            elements.RemoveAt(index2);
                            elements.RemoveAt(index1);
                        }
                        else
                        {

                            elements.RemoveAt(index1);
                            elements.RemoveAt(index2);
                        }
                        //string toRemove = elements[index1];
                        //elements.RemoveAll(x => x == toRemove); //maybe a error
                       
                    }
                    else if (elements[index1] != elements[index2])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                
            }
            if (elements.Count == 0)
            {
                Console.WriteLine($"You have won in {moves} turns!");
                
            }
            else if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
