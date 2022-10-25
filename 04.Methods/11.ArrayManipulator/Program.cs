using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "exchange")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (index >= input.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    Exchange(input, index);
                }
                if (action == "max")
                {
                    string variant = commandArgs[1];
                    Max(input, variant);
                }
                if (action == "min")
                {
                    string variant = commandArgs[1];
                    Min(input, variant);
                }
                if (action == "first" || action == "last")
                {
                    int count = int.Parse(commandArgs[1]);
                    string variant = commandArgs[2];
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;

                    }
                    if (action == "first")
                    {
                        FirstCount(input, count, variant);
                    }
                    else
                    {
                        LastCount(input, count, variant);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static void LastCount(int[] input, int count, string variant)
        {
            int arrayLenght = 0;
            if (variant == "even")
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (arrayLenght == count)
                    {
                        break;
                    }
                    if (input[i] % 2 == 0)
                    {
                        arrayLenght++;
                    }
                }
                int[] lastNumbers = new int[arrayLenght];
                int counter = lastNumbers.Length - 1;
                int arrayCounter = arrayLenght;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (arrayCounter == 0)
                        {
                            break;
                        }
                        lastNumbers[counter--] = input[i];
                        arrayCounter--;
                    }
                }
                Console.WriteLine($"[{string.Join(", ", lastNumbers)}]");
            }
            else if (variant == "odd")
            {

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (arrayLenght == count)
                    {
                        break;
                    }
                    if (input[i] % 2 == 1)
                    {
                        arrayLenght++;
                    }
                }
                int[] lastNumbers = new int[arrayLenght];
                int counter = lastNumbers.Length - 1;
                int arrayCounter = arrayLenght;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] % 2 == 1)
                    {
                        if (arrayCounter == 0)
                        {
                            break;
                        }
                        lastNumbers[counter--] = input[i];
                        arrayCounter--;
                    }
                }
                Console.WriteLine($"[{string.Join(", ", lastNumbers)}]");
            }
        }

        private static void FirstCount(int[] input, int count, string variant)
        {
            int arrayLenght = 0;
            if (variant == "even")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (arrayLenght == count)
                    {
                        break;
                    }
                    if (input[i] % 2 == 0)
                    {
                        arrayLenght++;
                    }
                }
                int[] firstNumbers = new int[arrayLenght];
                int counter = 0;
                int arrayCounter = arrayLenght;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0)
                    {
                        if (arrayCounter == 0)
                        {
                            break;
                        }
                        firstNumbers[counter++] = input[i];
                        arrayCounter--;
                    }
                }
                Console.WriteLine($"[{string.Join(", ", firstNumbers)}]");
            }
            else if (variant == "odd")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (arrayLenght == count)
                    {
                        break;
                    }
                    if (input[i] % 2 == 1)
                    {
                        arrayLenght++;
                    }
                }
                int[] firstNumbers = new int[arrayLenght];
                int counter = 0;
                int arrayCounter = arrayLenght;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 1)
                    {
                        if (arrayCounter == 0)
                        {
                            break;
                        }
                        firstNumbers[counter++] = input[i];
                        arrayCounter--;
                    }
                }
                Console.WriteLine($"[{string.Join(", ", firstNumbers)}]");
            }
        }

        private static void Min(int[] input, string variant)
        {
            int index = -1;
            int currentNum = int.MaxValue;
            if (variant == "even")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0 && currentNum >= input[i])
                    {
                        currentNum = input[i];
                        index = i;
                    }
                }
            }
            else if (variant == "odd")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 != 0 && currentNum >= input[i])
                    {
                        currentNum = input[i];
                        index = i;
                    }
                }
            }
            currentNum = int.MaxValue;
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void Max(int[] input, string variant)
        {
            int index = -1;
            int currentNum = int.MinValue;
            if (variant == "even")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 == 0 && currentNum <= input[i])
                    {
                        currentNum = input[i];
                        index = i;
                    }
                }
            }
            else if (variant == "odd")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] % 2 != 0 && currentNum <= input[i])
                    {
                        currentNum = input[i];
                        index = i;
                    }
                }
            }
            currentNum = int.MinValue;
            if (index == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(index);
            }
        }

        private static void Exchange(int[] input, int index)
        {
            for (int i = 0; i <= index; i++)
            {

                int current = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = current;
            }
            //Console.WriteLine(string.Join(", ", input));
        }
    }
}
