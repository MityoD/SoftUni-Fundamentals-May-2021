using System;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z][a-z]+)%.*<(?<product>[A-Za-z]+)>.*\|(?<count>[0-9]+)\|\D*(?<price>[0-9]+\.?[0-9]*)\$.*";

            //@"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            string command = "";
            decimal totalPrice = 0m;
            while ((command = Console.ReadLine()) != "end of shift")
            {
                MatchCollection purchase = Regex.Matches(command, pattern);
                if (purchase.Count == 0)
                {
                    continue;
                }
                foreach (Match item in purchase)
                {
                    decimal currentPrice = int.Parse(item.Groups["count"].Value.ToString()) * decimal.Parse(item.Groups["price"].Value.ToString());
                    Console.WriteLine($"{item.Groups["name"].Value.ToString()}: {item.Groups["product"].Value.ToString()} - {currentPrice:F2}");
                    totalPrice += currentPrice;
                }
            }
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}