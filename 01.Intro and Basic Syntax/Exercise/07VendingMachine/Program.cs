using System;

namespace _07VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            double sum = 0;

            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

            }
            string product = string.Empty;
            double price = 0;
            while ((product = Console.ReadLine()) != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sum >= price && (product == "Coke" || product == "Soda" || product == "Crisps" || product == "Water" || product == "Nuts"))
                {
                    sum -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }

            }
            Console.WriteLine($"Change: {sum:F2}");

        }
    }
}
