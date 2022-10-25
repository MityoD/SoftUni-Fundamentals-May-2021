using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.9;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.5;
                            break;
                    }
                    break;
            }
            double totalPrice = numOfPeople * price;
            if (typeOfGroup == "Students" && numOfPeople >= 30)
            {
                totalPrice *= 0.85;
            }
            if (typeOfGroup == "Business" && numOfPeople >= 100)
            {
                totalPrice = (numOfPeople - 10) * price;
            }
            if (typeOfGroup == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
