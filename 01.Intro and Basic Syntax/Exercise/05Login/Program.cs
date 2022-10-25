using System;

namespace _05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string pasword = "";
            int counter = 0;
            string login = "";
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pasword += userName[i];
            }

            while ((login = Console.ReadLine()) != pasword)
            {
                counter++;
                if (counter >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
            if (login == pasword)
            {
            Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
