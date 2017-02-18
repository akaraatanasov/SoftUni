using System;
using System.Linq;

namespace UnicodeChars
{
    public class Unicode
    {
        public static void Main()
        {
            var input = Console.ReadLine().Select(c => (int)c).Select(c => $@"\u{c:x4}");
            string result = string.Concat(input);
            Console.WriteLine(result);
        }
    }
}