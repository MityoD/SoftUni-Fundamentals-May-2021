using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program, which reads a list of integers from the console and receives commands, which manipulate the list. Your program may receive the following commands: 
	•	Delete {element} – delete all elements in the array, which are equal to the given element.
	•	Insert {element} {position} – insert an element and the given position.
You should stop the program when you receive the command "end". Print the numbers in the array separated by a single whitespace.
 */
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();
                if (commandArgs[0] == "Delete")
                {
                    int element = int.Parse(commandArgs[1]);
                    list.RemoveAll(x => x == element);
                }
                else
                {
                    int element = int.Parse(commandArgs[1]);
                    int position = int.Parse(commandArgs[2]);
                    list.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
