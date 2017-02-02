using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    public class Largest
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}