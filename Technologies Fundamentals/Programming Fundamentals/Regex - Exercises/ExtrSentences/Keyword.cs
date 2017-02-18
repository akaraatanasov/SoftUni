using System;
using System.Text.RegularExpressions;

namespace ExtrSentences
{
    public class Keyword
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"([^.!?]+)([\W])";

            Regex rgx = new Regex(pattern);
            string keyWordPattern = string.Format(@"(\b" + keyword + @"\b)");
            Regex rgxKeyW = new Regex(keyWordPattern);

            MatchCollection matches = rgx.Matches(text);

            foreach (Match match in matches)
            {
                if (rgxKeyW.IsMatch(match.Groups[1].Value))
                {
                    Console.WriteLine(match.Groups[1].Value.Trim());
                }
            }
        }
    }
}