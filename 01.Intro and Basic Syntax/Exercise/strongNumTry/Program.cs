using System;

namespace strongNumTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string number = num.ToString();
            int sum = 0;
            int str = 1;
            for (int i = 0; i < number.Length - 1; i++)
            {
                int index = Convert.ToInt32(number[i]);
                for (int j = 1; j <= index; j++)
                {
                    str *= j;
                }
                sum += str;
            }
            Console.WriteLine(sum);
        }
    }
}
