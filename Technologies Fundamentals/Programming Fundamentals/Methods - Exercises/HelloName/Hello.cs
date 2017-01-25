using System;

namespace HelloName
{
    class Hello
    {
        public static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            PrintName(input);
        }
    }
}