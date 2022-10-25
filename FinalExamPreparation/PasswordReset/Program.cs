using System;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newPassword = "";
            string command = "";
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] commandArgs = command.Split();
                if (commandArgs[0] == "TakeOdd")
                {
                    for (int i = 1; i < input.Length; i += 2)
                    {
                        newPassword += input[i];
                    }
                    input = newPassword;
                    Console.WriteLine(input);
                }
                else if (commandArgs[0] == "Cut")
                {

                    int index = int.Parse(commandArgs[1]);
                    int lenght = int.Parse(commandArgs[2]);
                    string toRemove = input.Substring(index, lenght);
                    int startIndex = input.IndexOf(toRemove);
                    input = input.Remove(startIndex, lenght);
                    Console.WriteLine(input);
                }
                else if (commandArgs[0] == "Substitute")
                {
                    string substring = commandArgs[1];
                    string substitute = commandArgs[2];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }
                    input = input.Replace(substring, substitute);
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
