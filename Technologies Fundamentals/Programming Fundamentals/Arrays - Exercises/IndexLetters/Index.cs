using System;
using System.Linq;

namespace IndexLetters
{
    class Index
    {
        public static void Main()
        {
            char[] array = Console.ReadLine().ToArray();
            char[] alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            for (int i = 0; i < array.Length; i++)
            {
                int index = 0;

                for (int j = 0; j < 26; j++)
                {
                    if (array[i] == alphabet[j])
                    {
                        index = j;
                    }
                }

                Console.WriteLine($"{array[i]} -> {index}");
            }
        }
    }
}