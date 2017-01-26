using System;

namespace DaysOfWeek
{
    class Days
    {
        public static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            string[] arrayOfDays = new string[]
                {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine($"{arrayOfDays[day-1]}");
            }
        }
    }
}