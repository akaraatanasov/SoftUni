using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicWords
{
    public class Exchangeable
    {
        public static void Main()
        {
            var letters = new Dictionary<char, char>();

            var input = Console.ReadLine().Split(' ').ToArray();

            string firstWord = input[0];
            string secondWord = input[1];

            bool isExchangeable = true;
            int minLength = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (!letters.ContainsKey(firstWord[i]))
                {
                    if (!letters.ContainsValue(secondWord[i]))
                    {
                        letters.Add(firstWord[i], secondWord[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (letters[firstWord[i]] != secondWord[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            string rest = String.Empty;

            if (firstWord.Length > secondWord.Length)
            {
                rest = firstWord.Substring(minLength);
            }
            else
            {
                rest = secondWord.Substring(minLength);
            }

            foreach (var letter in rest)
            {
                if (!letters.ContainsValue(letter) && !letters.ContainsKey(letter))
                {
                    isExchangeable = false;
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}