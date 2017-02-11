using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Library
    {
        public static void Main()
        {
            int numOfBooks = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            for (int i = 0; i < numOfBooks; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                };

                books.Add(book);
            }

            List<Book> output = new List<Book>(books.OrderByDescending(s => s.Price).ThenBy(a => a.Title).ToList());

            var authorAndPriceSum = new Dictionary<string, double>();

            foreach (var book in output)
            {
                if(!authorAndPriceSum.ContainsKey(book.Author))
                {
                    authorAndPriceSum[book.Author] = book.Price;
                }
                else
                {
                    authorAndPriceSum[book.Author] += book.Price;
                }
            }

            foreach (var result in authorAndPriceSum)
            {
                Console.WriteLine($"{result.Key} -> {result.Value:f2}");
            }

        }
    }
}