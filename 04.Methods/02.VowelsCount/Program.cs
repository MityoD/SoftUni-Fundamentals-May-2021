using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //'a', 'e', 'i', 'o', 'u'
            string input = Console.ReadLine();
            VowelsCount(input);

        }

        private static void VowelsCount(string input)
        {
            //int count = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i'|| input[i] == 'o' || input[i] == 'u'|| input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            string toLower = input.ToLower();
            int count = toLower.Count(c => vowels.Contains(c));
            Console.WriteLine(count);

        }
    }
}
