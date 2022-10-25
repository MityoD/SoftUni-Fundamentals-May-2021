using System;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in userNames)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    if (item.All(char.IsLetterOrDigit) || item.Contains("-") || item.Contains("_"))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
