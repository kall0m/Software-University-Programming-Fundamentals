using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int phraseIndexer = rnd.Next(0, phrases.Length - 1);
                int eventsIndexer = rnd.Next(0, events.Length - 1);
                int authorsIndexer = rnd.Next(0, authors.Length - 1);
                int citiesIndexer = rnd.Next(0, cities.Length - 1);

                Console.WriteLine($"{phrases[phraseIndexer]} {events[eventsIndexer]} {authors[authorsIndexer]} – {cities[citiesIndexer]}");
            }
        }
    }
}
