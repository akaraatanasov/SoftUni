using System;
using System.Globalization;

namespace SinoTheWalker
{
    public class TheWalker
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();
            var time = new DateTime();

            if (input[2] == ':' && input[5] == ':')
            {
                if (char.IsNumber(input[0]) && char.IsNumber(input[1]) && char.IsNumber(input[3]) && char.IsNumber(input[4]) && char.IsNumber(input[6]) && char.IsNumber(input[7]))
                {
                    time = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

            int minutes = (steps * secondsPerStep)/60;
            int seconds = (steps * secondsPerStep)%60;

            time = time.AddMinutes(minutes);
            time = time.AddSeconds(seconds);

            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", time.Hour, time.Minute, time.Second);
        }
    }
}