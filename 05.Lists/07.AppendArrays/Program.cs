using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string[] input = Console.ReadLine().Split('|').Reverse().ToArray();
string temporal = string.Join(" ", input);
string[] rezult = temporal.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
Console.WriteLine(string.Join(" ", rezult));*/
            List<string> array = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            for (int i = 0; i < array.Count; i++)
            {
                List<string> work = array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < work.Count; j++)
                {
                    Console.Write($"{work[j]} ");
                }
            }
        }
    }
}
