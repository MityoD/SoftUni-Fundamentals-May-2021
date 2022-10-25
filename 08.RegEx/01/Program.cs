using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string patern = @"^>>(?<type>[A-Za-z]+)<<(?<price>[0-9]+\.{0,1}[0-9]*)!(?<qty>[0-9]+)";
            decimal totalPrice = 0;
            Console.WriteLine("Bought furniture:");
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, patern);
                if (!match.Success)
                {
                    continue;
                }
                string productName = match.Groups["type"].Value;
                decimal price = decimal.Parse(match.Groups["price"].Value);
                int qty = int.Parse(match.Groups["qty"].Value);

                totalPrice += price * qty;
                Console.WriteLine(productName);
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");


        }
    }
}
