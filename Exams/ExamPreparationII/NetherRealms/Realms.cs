using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    public class Realms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse)
                .OrderBy(a => a.Name)
                .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            } 
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }

        public static Demon Parse(string demonName)
        {
            var demon = new Demon();

            demon.Name = demonName;

            demon.Health = CalucalteHealth(demonName);

            demon.Damage = CalucateDamage(demonName);

            return demon;
        }

        private static double CalucateDamage(string demonName)
        {
            var damagePattern = @"[+-]?\d+(?:\.?\d+)?";

            var damageChars = Regex.Matches(demonName, damagePattern);

            double damageSum = 0;

            foreach (Match match in damageChars)
            {
                damageSum += double.Parse(match.Value);
            }

            var modifiers = demonName.Where(a => a == '*' || a == '/').ToArray();

            foreach (var modifier in modifiers)
            {
                switch (modifier)
                {
                    case '*': damageSum *= 2; break;
                    case '/': damageSum /= 2; break;
                }
            }

            return damageSum;
        }

        private static int CalucalteHealth(string demonName)
        {
            var healthPattern = @"[^0-9+\-*\/\.]";

            var healthChars = Regex.Matches(demonName, healthPattern);

            var healthValues = new List<int>();

            foreach (Match match in healthChars)
            {
                healthValues.Add(char.Parse(match.Value));
            }

            var health = healthValues.Sum();
            return health;
        }
    }
}