using System;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = "";
            while ((command = Console.ReadLine())!= "Reveal")
            {
                string[] commandArgs = command.Split(":|:");
                string action = commandArgs[0];
                if (action == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);
                    input = input.Insert(index, " ");
                    Console.WriteLine(input);

                }
                else if (action == "Reverse")
                {
                    string substring = commandArgs[1];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    int index = input.IndexOf(substring);
                    string toReverse = input.Substring(index, substring.Length);
                    input = input.Remove(index, substring.Length);
                    string toAdd = "";
                    for (int i = toReverse.Length - 1; i >= 0; i--)
                    {
                        toAdd += toReverse[i];
                    }
                    input += toAdd;
                    Console.WriteLine(input);

                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];
                    input = input.Replace(substring, replacement);
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
