using System;
using System.Linq;
using System.Collections.Generic;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*	•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}"*/
            string command = "";
            var products = new Dictionary<string, List<double>>();
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] commandArgs = command.Split();
                string item = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                double qty = double.Parse(commandArgs[2]);
                var items = new List<double>();
                if (!products.ContainsKey(item))
                {
                    items.Add(price);
                    items.Add(qty);
                    products.Add(item, items);
                    continue;
                }
                products[item][0] = price;
                products[item][1] += qty;
            }
            foreach (var item in products)
            {
            Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:F2}");

            }

        }
    }
}
