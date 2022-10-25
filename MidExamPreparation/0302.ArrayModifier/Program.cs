using System;
using System.Linq;

namespace _0302.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "swap")
                {
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);
                    int tempValue = array[index1];
                    array[index1] = array[index2];
                    array[index2] = tempValue;
                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(commandArgs[1]);
                    int index2 = int.Parse(commandArgs[2]);
                    array[index1] *= array[index2];
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }
             }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
