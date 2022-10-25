using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string coded = "";
            for (int i = 0; i < input.Length; i++)
            {
                coded += (char)(input[i] + 3);
            }
            Console.WriteLine(coded);
        }
    }
}
