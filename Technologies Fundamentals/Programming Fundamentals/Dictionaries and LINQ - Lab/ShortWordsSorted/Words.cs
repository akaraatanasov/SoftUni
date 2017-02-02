using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    public class Words
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(String.Join(", ", input));
        }
    }
}