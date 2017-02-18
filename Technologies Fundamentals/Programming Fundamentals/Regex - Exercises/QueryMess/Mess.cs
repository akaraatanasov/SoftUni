using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QueryMess
{
    public class Mess
    {
        public static void Main()
        {
            Regex rgx1 = new Regex(@"([^&?]+)=([^&?]+)");

            var input = Console.ReadLine();

            while (input != "END")
            {
                MatchCollection matches = rgx1.Matches(input);
                var results = new List<string>();

                foreach (Match match in matches)
                {
                    string noSpaces = Regex.Replace(match.Groups[0].ToString(), @"(\+|%20)", " ");
                    noSpaces = Regex.Replace(noSpaces, @"\s+", " ");
                    results.Add(noSpaces);
                }
                var lineItems = new Dictionary<string, List<string>>();

                foreach (var result in results)
                {
                    string[] keyAndValue = result.Split('=').Select(x => x.Trim()).ToArray();
                    string key = keyAndValue[0];
                    string value = keyAndValue[1];

                    if (!lineItems.ContainsKey(key))
                    {
                        lineItems.Add(key, new List<string> { value });
                    }
                    else
                    {
                        lineItems[key].Add(value);
                    }
                }

                foreach (var keyAndValue in lineItems)
                {
                    Console.Write($"{keyAndValue.Key}=[{string.Join(", ", keyAndValue.Value)}]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}