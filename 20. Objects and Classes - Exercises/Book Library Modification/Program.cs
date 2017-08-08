using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library_Modification
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

            library.Books = ReadBooks().ToList();

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books.Where(b => b.ReleaseDate > date).OrderBy(b => b.ReleaseDate).ThenBy(b => b.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
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
