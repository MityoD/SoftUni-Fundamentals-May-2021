using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int newM = m + 30;
            if (newM > 59)
            {
                newM -= 60;
                h += 1; 
            }
            if (h > 23)
            {
                h = 0;
            }
            Console.WriteLine($"{h}:{newM:D2}");
        }
    }
}
