using System;
using System.Linq;

namespace ReverseString
{
    class Reverse
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');

            Array.Reverse(array);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}