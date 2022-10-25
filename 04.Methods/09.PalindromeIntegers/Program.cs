using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "END")
            {
                int num = int.Parse(command);
                bool isPalindrome = IsPalindrome(command);
                Console.WriteLine(isPalindrome);
                command = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string command)
        {
            bool result = false;
            string[] newCommand = new string[command.Length];
            for (int i = 0; i < command.Length; i++)
            {
                newCommand[i] = command[command.Length - 1 - i].ToString();
            }
            string compare = string.Join("", newCommand);
            if (compare == command)
            {
                result = true;
                return result;
            }
            return result;

        }
    }
}
