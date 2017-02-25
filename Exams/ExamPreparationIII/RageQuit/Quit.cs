using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RageQuit
{
    public class Quit
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var pattern = @"(.*?[^0-9])(\d+)";
            var regex = new Regex(pattern);

            var sequence = regex.Matches(input);

            var newSequence = new List<string>();

            foreach (Match match in sequence)
            {
                string letters = match.Groups[1].ToString().ToUpper();
                int multiplier = int.Parse(match.Groups[2].ToString());

                for (int i = 0; i < multiplier; i++)
                {
                    newSequence.Add(letters);
                }
            }

            string result = String.Join("", newSequence);

            char[] uniqueChars = result.ToCharArray();
            uniqueChars = uniqueChars.Distinct().ToArray();

            Console.WriteLine($"Unique symbols used: {uniqueChars.Length}");
            Console.WriteLine(result);
        }
    }
}