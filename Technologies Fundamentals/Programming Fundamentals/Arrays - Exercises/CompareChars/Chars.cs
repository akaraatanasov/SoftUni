using System;
using System.Linq;

namespace CompareChars
{
    class Chars
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine(String.Join("", firstArray));
                Console.WriteLine(String.Join("", secondArray));
            }
            else if (secondArray.Length < firstArray.Length)
            {
                Console.WriteLine(String.Join("", secondArray));
                Console.WriteLine(String.Join("", firstArray));
            }
            else
            {
                if (firstArray[0] > secondArray[0])
                {
                    Console.WriteLine(String.Join("", secondArray));
                    Console.WriteLine(String.Join("", firstArray));
                }
                else
                {
                    Console.WriteLine(String.Join("", firstArray));
                    Console.WriteLine(String.Join("", secondArray));
                }
            }
        }
    }
}