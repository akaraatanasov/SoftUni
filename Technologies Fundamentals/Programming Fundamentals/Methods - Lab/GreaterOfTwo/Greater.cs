using System;

namespace GreaterOfTwo
{
    class Greater
    {
        public static int GetMax(int firstInt, int secondInt)
        {
            if(firstInt > secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }

        public static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        public static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString)>=0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        public static void Main()
        {
            var type = Console.ReadLine();
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            Console.WriteLine(GetMax(first, second));
        }
    }
}