using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulCounter
{
    public class Counter
    {
        public static void Main()
        {
            var CountryAndCities = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();
            while (!input.Equals("report"))
            {
                var allInput = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!CountryAndCities.ContainsKey(allInput[1]))
                {
                    CountryAndCities.Add(allInput[1], new Dictionary<string, long>());
                    CountryAndCities[allInput[1]].Add(allInput[0], long.Parse(allInput[2]));
                }
                else
                {
                    CountryAndCities[allInput[1]].Add(allInput[0], long.Parse(allInput[2]));
                }

                input = Console.ReadLine();
            }

            foreach (var country in CountryAndCities.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}