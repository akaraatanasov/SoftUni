using System;
using System.Linq;

namespace MathOperations
{
    public class Math
    {
        public static void Main()
        {
            int numOfItems = int.Parse(Console.ReadLine());
            var items = new int[numOfItems];

            for (int i = 0; i < numOfItems; i++)
            {
                items[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {items.Sum()}");
            Console.WriteLine($"Min = {items.Min()}");
            Console.WriteLine($"Max = {items.Max()}");
            Console.WriteLine($"Average = {items.Average()}");
        }
    }
}