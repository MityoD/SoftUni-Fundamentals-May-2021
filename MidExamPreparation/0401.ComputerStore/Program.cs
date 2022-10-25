using System;

namespace _0401.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";//Console.ReadLine();
            decimal sum = 0m;
            decimal tax = 0m;
            while ((command = Console.ReadLine()) != "special" && command != "regular")
            {
                decimal price = decimal.Parse(command);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    //command = Console.ReadLine();
                    continue;
                }
                else
                {
                    sum += price;
                }
                //command = Console.ReadLine();
            }
            tax = sum * 0.2m;
            decimal totalSum = sum + tax;
            if (totalSum > 0)
            {
                if (command == "special")
                {
                    totalSum *= 0.9m;
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:F2}$");
                Console.WriteLine($"Taxes: {tax:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:F2}$");

            }
            else
            {
                Console.WriteLine("Invalid order!");
            }

        }
    }
}
