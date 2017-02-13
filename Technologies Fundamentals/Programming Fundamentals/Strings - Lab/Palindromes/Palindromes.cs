using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var palindromes = new List<string>();

            foreach (var word in input)
            {
                if (ReverseString(word).Equals(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", palindromes.OrderBy(w => w).Distinct()));
        }

        public static string ReverseString(string s)
        {
            var sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}