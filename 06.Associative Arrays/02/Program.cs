using System;
using System.Collections.Generic;
using System.Numerics;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper, and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.
*/
            string input = "";
            int count = 0;
            string temp = "";
            Dictionary<string, BigInteger> mined = new Dictionary<string, BigInteger>();
            while ((input = Console.ReadLine()) != "stop")
            {
                if (count % 2 == 0)
                {
                    if (!mined.ContainsKey(input))
                    {
                        mined.Add(input, 0);
                    }
                    temp = input;
                }
                else
                {
                    BigInteger qty = BigInteger.Parse(input);
                    mined[temp] += qty;
                }
                count++;
            }
            foreach (var (key, value) in mined)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
