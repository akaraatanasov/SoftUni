using System;
using System.Globalization;

namespace DayOfWeek
{
    public class Day
    {
        public static void Main()
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);            
        }
    }
}