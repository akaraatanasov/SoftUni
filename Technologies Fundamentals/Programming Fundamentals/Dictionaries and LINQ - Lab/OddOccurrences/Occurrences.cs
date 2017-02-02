using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    public class Occurrences
    {
        public static void Main()
        {
            var list = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            var words = new Dictionary<string, int>();

            foreach (var word in list)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = 0;
                }

                words[word]++;
            }

            var results = new List<string>();

            foreach (var count in words)
            {
                if (count.Value % 2 == 1)
                {
                    results.Add(count.Key);
                }
            }

            Console.WriteLine(String.Join(", ", results));

        }
    }
}