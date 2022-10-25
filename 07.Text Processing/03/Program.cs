using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Internal\training-internal\Template.pptx
            //File name: Template
            //File extension: pptx
            string[] input = Console.ReadLine().Split("\\");
            string[] nameAndExt = input[input.Length - 1].Split(".");            
            Console.WriteLine($"File name: {nameAndExt[0]}");
            Console.WriteLine($"File extension: {nameAndExt[1]}");
        }
    }
}
