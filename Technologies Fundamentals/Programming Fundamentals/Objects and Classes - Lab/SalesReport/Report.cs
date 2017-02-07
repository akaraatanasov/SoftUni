using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    public class Report
    {
        public static void Main()
        {
            int numOfSales = int.Parse(Console.ReadLine());

            var results = new SortedDictionary<string, double>();

            for (int i = 0; i < numOfSales; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var currentSale = new Sales
                {
                    Town = input[0],
                    Product = input[1],
                    Price = double.Parse(input[2]),
                    Quantity = double.Parse(input[3])
                };

                if (!results.ContainsKey(currentSale.Town))
                {
                    results[currentSale.Town] = currentSale.Total;
                }
                else
                {
                    results[currentSale.Town] += currentSale.Total;
                }

            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Key} -> {result.Value:F2}");
            }
        }
    }
}