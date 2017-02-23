using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    public class Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double avrg = numbers.Average();

            var results = new List<int>();
            foreach (var number in numbers)
            {
                if (number > avrg)
                {
                    results.Add(number);
                }
            }

            if (results.Any())
            {
                int count = 5;
                foreach (var result in results.OrderByDescending(x => x))
                {
                    Console.Write("{0} ", result);
                    count--;

                    if (count == 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}