using System;
using System.Collections.Generic;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {            
            int regNum = int.Parse(Console.ReadLine());
            Dictionary<string, string> registrationDB = new Dictionary<string, string>();
            for (int i = 0; i < regNum; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                if (commandArgs[0] == "register")
                {
                    string username = commandArgs[1];
                    string licensePlateNum = commandArgs[2];
                    if (registrationDB.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registrationDB[username]}");
                    }
                    else
                    {
                        registrationDB.Add(username, licensePlateNum);
                        Console.WriteLine($"{username} registered {licensePlateNum} successfully");
                    }
                }
                else
                {
                    string username = commandArgs[1];
                    if (!registrationDB.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registrationDB.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var (user, regPlate) in registrationDB)
            {
                Console.WriteLine($"{user} => {regPlate}");
            }
        }
    }
}
