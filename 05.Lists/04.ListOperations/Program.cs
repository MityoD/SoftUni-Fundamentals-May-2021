using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string operation = "";
            while ((operation = Console.ReadLine()) != "End")
            {
                string[] commandArgs = operation.Split();
                if (commandArgs[0] == "Add")
                {
                    int num = int.Parse(commandArgs[1]);
                    numbers.Add(num);
                }
                else if (commandArgs[0] == "Insert")
                {
                    int num = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index < numbers.Count && index >= 0)
                    {
                    numbers.Insert(index, num);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commandArgs[0] == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index < numbers.Count && index >=0)
                    {
                    numbers.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commandArgs[0] == "Shift")
                {
                    int count = int.Parse(commandArgs[2]);
                    if (commandArgs[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int temp = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(temp);
                        }
                    }
                    else if (commandArgs[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                        int temp = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, temp);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
