using System;
using System.Text;
using System.Text.RegularExpressions;

namespace UseChains
{
    public class YourChains
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex rgx = new Regex(@"<p>(.*?)<\/p>");

            MatchCollection matches = rgx.Matches(input);

            StringBuilder rawMessage = new StringBuilder();

            foreach (Match match in matches)
            {
                string treatedEntry = match.Groups[1].Value;

                treatedEntry = Regex.Replace(treatedEntry, @"[^a-z0-9]", " ");
                treatedEntry = Regex.Replace(treatedEntry, @"\s+", " ");

                rawMessage.Append(treatedEntry);
            }

            var finalText = new StringBuilder();

            foreach (char sym in rawMessage.ToString())
            {
                char changedChar = sym;

                if (sym != ' ')
                {
                    if (sym >= 97 && sym <= 109)
                    {
                        changedChar = (char)(sym + 13);
                    }
                    else if (sym >= 110 && sym <= 122)
                    {
                        changedChar = (char)(sym - 13);
                    }
                }

                finalText.Append(changedChar);
            }

            Console.WriteLine(finalText);
        }
    }
}