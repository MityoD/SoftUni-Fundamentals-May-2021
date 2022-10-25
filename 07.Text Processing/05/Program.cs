using System;
using System.Text;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string numOne = Console.ReadLine();
            int numTwo = int.Parse(Console.ReadLine());
            int reminder = 0;
            if (numOne =="0" || numTwo == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = numOne.Length - 1; i >= 0; i--)
            {
                int result = (int.Parse(numOne[i].ToString())) * numTwo + reminder;
                int currentDigit = result % 10;
                reminder = result / 10;
                sb.Insert(0, currentDigit);
            }
            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb);
        }
    }
}
