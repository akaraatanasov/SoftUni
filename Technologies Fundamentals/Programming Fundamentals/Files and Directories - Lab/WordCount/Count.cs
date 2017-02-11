using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordCount
{
    public class Count
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToArray();

            var text = File.ReadAllText("text.txt").Split(new[] { ' ', '-', '.', ',', '?', '!', '…', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToArray();

            var results = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var currentCount = 0;

                for (int j = 0; j < text.Length; j++)
                {
                    if (currentWord == text[j])
                    {
                        currentCount++;
                    }
                }

                results[currentWord] = currentCount;
            }

            foreach (var result in results.OrderByDescending(kvp => kvp.Value))
            {
                File.AppendAllText("Output.txt", $"{result.Key} - {result.Value}" + Environment.NewLine);
            }
        }
    }
}