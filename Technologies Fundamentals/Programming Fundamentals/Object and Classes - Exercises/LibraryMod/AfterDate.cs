using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LibraryMod
{
    public class AfterDate
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
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                };

                books.Add(book);
            }

            DateTime afterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            List<Book> output = new List<Book>(books.Where(st => st.ReleaseDate > afterDate).OrderBy(s => s.ReleaseDate).ThenBy(a => a.Title).ToList());

            foreach (var result in output)
            {
                Console.WriteLine($"{result.Title} -> {result.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}