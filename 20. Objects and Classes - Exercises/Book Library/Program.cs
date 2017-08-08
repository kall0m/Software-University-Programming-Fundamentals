using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    class Program
    {
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        static void Main(string[] args)
        {
            Library library = new Library();

            library.Books = ReadBooks().OrderByDescending(b => b.Price).ThenBy(b => b.Author).ToList();

            var authorSales = new Dictionary<string, decimal>();

            foreach (var book in library.Books)
            {
                if (!authorSales.ContainsKey(book.Author))
                {
                    authorSales[book.Author] = 0;
                }

                authorSales[book.Author] += book.Price;
            }

            foreach (var author in authorSales)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }

        static Book[] ReadBooks()
        {
            int n = int.Parse(Console.ReadLine());

            Book[] books = new Book[n];

            for (int i = 0; i < n; i++)
            {
                books[i] = ReadBook();
            }

            return books;
        }

        static Book ReadBook()
        {
            var bookInfo = Console.ReadLine().Split();

            return new Book()
            {
                Title = bookInfo[0],
                Author = bookInfo[1],
                Publisher = bookInfo[2],
                ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = bookInfo[4],
                Price = decimal.Parse(bookInfo[5])
            };
        }
    }
}
