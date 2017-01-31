using System;
using System.Collections.Generic;
using System.Linq;

namespace AdjacentEquals
{
    public class Adjacent
    {
        public static void Main()
        {
            List<double> numbers = new List<double>();
            List<string> list = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(double.Parse(list[i]));
            }

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                while (i < numbers.Count - 1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers[i] = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i + 1);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}