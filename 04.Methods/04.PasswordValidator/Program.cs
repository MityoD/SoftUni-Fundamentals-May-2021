using System;
using System.Linq;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool validSymbolsAmount = ValidSymbolsAmount(password);
            bool validChars = ValidChars(password);
            bool validDigits = ValidDigits(password);
            if (validChars && validDigits && validSymbolsAmount)
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        private static bool ValidSymbolsAmount(string password)
        {
            bool result = password.Length >= 6 && password.Length <= 10;
            if (!result)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        private static bool ValidChars(string password)
        {
            bool result = password.All(char.IsLetterOrDigit);
            if (!result)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
            return true;
        }

        private static bool ValidDigits(string password)
        {
            bool result = password.Count(char.IsDigit) >= 2;
            if (!result)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}
