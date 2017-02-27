using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    public class Assault
    {
        public static void Main()
        {
            try
            {
                var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
                var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

                var beehivesRemaining = new List<long>();

                long summedPower = hornets.Sum();

                foreach (var bee in beehives)
                {
                    if (bee - summedPower > 0)
                    {
                        long currentHive = bee - summedPower;
                        beehivesRemaining.Add(currentHive);
                        hornets.RemoveAt(0);
                        summedPower = hornets.Sum();
                    }
                    else if (bee - summedPower == 0)
                    {
                        hornets.RemoveAt(0);
                        summedPower = hornets.Sum();
                    }
                }

                if (beehivesRemaining.Any())
                {
                    Console.WriteLine(String.Join(" ", beehivesRemaining));
                }
                else if (hornets.Any())
                {
                    Console.WriteLine(String.Join(" ", hornets));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }

        }
    }
}