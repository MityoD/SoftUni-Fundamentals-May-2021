using System;
using System.Collections.Generic;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                foreach (var item in input[i])
                {
                    if (!chars.ContainsKey(item))
                    {
                        chars.Add(item, 0);

                    }
                    chars[item] += 1;
                }
            }
            foreach (var (key, num) in chars)
            {
                Console.WriteLine($"{key} -> {num}");
            }            
        }
    }
}
