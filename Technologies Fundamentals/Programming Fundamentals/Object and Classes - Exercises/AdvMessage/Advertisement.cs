using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvMessage
{
    public class Advertisement
    {
        public static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            var phrases = new string[]
            {   "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new string[]
            {   "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            var phraseIndex = new Random();
            var eventIndex = new Random();
            var authorIndex = new Random();
            var cityIndex = new Random();

            for (int i = 0; i < numberOfMessages; i++)
            {
                int phraseI = phraseIndex.Next(0, phrases.Length);
                int eventI = eventIndex.Next(0, events.Length);
                int authorI = authorIndex.Next(0, authors.Length);
                int cityI = cityIndex.Next(0, cities.Length);

                Console.WriteLine($"{phrases[phraseI]} {events[eventI]} {authors[authorI]} - {cities[cityI]}");
            }

        }
    }
}