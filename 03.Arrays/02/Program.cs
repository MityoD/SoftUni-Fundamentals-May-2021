using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            string common = "";
            for (int i = 0; i < secondArray.Length; i++)
            {
                string currentElement = secondArray[i];
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (currentElement == firstArray[j])
                    {
                        common += currentElement + " ";
                    }
                }
            }
            Console.WriteLine(common);
        }
    }
}
