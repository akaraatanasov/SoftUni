using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class Extract
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@[a-z]+\-?[a-z]+(?:\.[a-z]+)+)\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            var emails = new List<string>();

            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }

            Console.WriteLine(String.Join("\n", emails));
        }
    }
}