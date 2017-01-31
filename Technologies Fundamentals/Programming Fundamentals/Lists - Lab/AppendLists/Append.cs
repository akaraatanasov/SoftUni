using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    public class Append
    {
        public static void Main()
        {
            var items = Console.ReadLine().Split('|').ToList();
            items.Reverse();

            var result = new List<string>();

            foreach (var item in items)
            {
                List<string> numbers = item.Split(' ').ToList();
                foreach (var num in numbers)
                {
                    if (num != "")
                    {
                        result.Add(num);
                    }
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}