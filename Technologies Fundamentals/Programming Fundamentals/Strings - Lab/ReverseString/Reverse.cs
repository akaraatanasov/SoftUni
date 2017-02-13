using System;

namespace ReverseString
{
    public class Reverse
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReverseString(input));
        }

        public static string ReverseString(string s)
        {
            var sb = new System.Text.StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }
    }
}