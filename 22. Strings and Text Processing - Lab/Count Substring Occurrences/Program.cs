using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();

            var word = Console.ReadLine().ToLower();

            var count = 0;

            var index = -1;

            while ((index = text.IndexOf(word, index + 1)) != -1)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
