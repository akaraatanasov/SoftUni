using System;
using System.Linq;

namespace RevNumber
{
    static class Reversed
    {
        public static string Reverse(this string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }
        public static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Reverse(number));
        }
    }
}