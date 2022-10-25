using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(@#{1,})([A-Z][A-Za-z0-9]{4,}[A-Z])(@#{1,})$";
            string numPattern = @"[0-9]";
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string barcode = Console.ReadLine();
                Match match = Regex.Match(barcode, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                MatchCollection productGroup = Regex.Matches(barcode, numPattern);
                if (productGroup.Count == 0)
                {
                    Console.WriteLine("Product group: 00");
                }
                else
                {
                    Console.Write("Product group: ");
                    foreach (Match item in productGroup)
                    {
                        Console.Write(item.Value);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
