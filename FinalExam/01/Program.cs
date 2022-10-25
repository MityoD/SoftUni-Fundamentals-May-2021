using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {            
            string username = Console.ReadLine();
            string command = "";
            while ((command = Console.ReadLine())!= "Sign up")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "Case")
                {
                    string currentUsername = "";
                    string subAction = commandArgs[1];
                    if (subAction == "lower")
                    {
                        for (int i = 0; i < username.Length; i++)
                        {
                            currentUsername += char.ToLower(username[i]);
                        }
                    }
                    else if (subAction == "upper")
                    {
                        for (int i = 0; i < username.Length; i++)
                        {
                            currentUsername += char.ToUpper(username[i]);
                        }
                    }
                    username = currentUsername;
                    currentUsername = "";
                    Console.WriteLine(username);
                }
                else if (action == "Reverse")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    if (startIndex >= 0 && startIndex < username.Length && endIndex >= 0 && endIndex < username.Length)
                    {
                        string subString = username.Substring(startIndex, endIndex - startIndex + 1);
                        string reversed = "";
                        for (int i = subString.Length - 1; i >= 0; i--)
                        {
                            reversed += subString[i];
                        }
                        Console.WriteLine(reversed);
                        reversed = "";
                    }
                }
                else if (action == "Cut")
                {
                    string substring = commandArgs[1];
                    int index = username.IndexOf(substring);
                    if (index < 0)
                    {
                        Console.WriteLine($"The word {username} doesn't contain {substring}.");                        
                    }
                    else
                    {
                        username = username.Remove(index, substring.Length);
                        Console.WriteLine(username);
                    }
                }
                else if (action == "Replace")
                {
                    string letter = commandArgs[1];
                    username = username.Replace(letter, "*");
                    Console.WriteLine(username);
                }
                else if (action == "Check")
                {
                    string letter = commandArgs[1];
                    if (!username.Contains(letter))
                    {                        
                        Console.WriteLine($"Your username must contain {letter}.");
                    }
                    else
                    {
                        Console.WriteLine("Valid");
                    }

                }
            }
            
        }
    }
}
