using System;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            string command = "";
            decimal totalPrice = 0m;
            while ((command = Console.ReadLine()) != "end of shift")
            {
                if (Regex.IsMatch(command, pattern))
                {
                    Match match = Regex.Match(command, pattern);
                
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal money = price * count;
                    Console.WriteLine($"{name}: {product} - {money:F2}");
                    totalPrice += money;
                }
               
                //foreach (Match item in purchase)
                //{
                //    decimal currentPrice = int.Parse(item.Groups["count"].Value.ToString()) * decimal.Parse(item.Groups["price"].Value.ToString());
                //    Console.WriteLine($"{item.Groups["name"].Value.ToString()}: {item.Groups["product"].Value.ToString()} - {currentPrice:F2}");
                //    totalPrice += currentPrice;
                //}
            }
            Console.WriteLine($"Total income: {totalPrice:F2}");
        }
    }
}
/*using System;
using System.Text.RegularExpressions;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double totalIncome = 0;

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end of shift")
                {
                    break;
                }

                if (Regex.IsMatch(line, pattern))
                {
                    Match match = Regex.Match(line, pattern);
                    var customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * count;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    totalIncome += money;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}*/
