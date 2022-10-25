using System;
using System.Text;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string newInput = "";
            string input = Console.ReadLine();

            string command = "";
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArgs = command.Split(">>>");
                if (commandArgs[0] == "Contains")
                {
                    if (input.Contains(commandArgs[1]))
                    {
                        Console.WriteLine($"{input} contains {commandArgs[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }


                }
                else if (commandArgs[0] == "Flip")
                {
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);

                    if (commandArgs[1] == "Upper")
                    {
                        newInput = input.Substring(startIndex, endIndex - startIndex);
                        input = input.Remove(startIndex, endIndex - startIndex);
                        for (int i = 0; i < newInput.Length; i++)
                        {
                            newInput = newInput.Replace(newInput[i], char.ToUpper(newInput[i]));
                        }
                        input = input.Insert(startIndex, newInput);
                    }

                    else if (commandArgs[1] == "Lower")
                    {
                        newInput = input.Substring(startIndex, endIndex - startIndex);
                        input = input.Remove(startIndex, endIndex - startIndex);
                        for (int i = 0; i < newInput.Length; i++)
                        {
                            newInput = newInput.Replace(newInput[i], char.ToLower(newInput[i]));
                        }
                        input = input.Insert(startIndex, newInput);

                    }


                    Console.WriteLine(input);
                }
                else if (commandArgs[0] == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);

                }
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
