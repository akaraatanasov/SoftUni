using System;

namespace HornetWings
{
    public class Wings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double metersPer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double metersTraveled = (wingFlaps / 1000) * metersPer1000Flaps;
            int flapTime = wingFlaps / 100;
            int restTime = (wingFlaps / endurance) * 5;
            int secondsPassed = flapTime + restTime;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsPassed} s.");
        }
    }
}