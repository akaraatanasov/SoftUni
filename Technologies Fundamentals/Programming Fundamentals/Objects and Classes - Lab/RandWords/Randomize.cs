using System;
using System.Linq;

namespace RandWords
{
    public class Randomize
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);
                string tempWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = tempWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}