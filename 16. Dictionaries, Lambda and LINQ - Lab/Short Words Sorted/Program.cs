using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().ToLower().Split('.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ').ToList();

            Console.WriteLine(string.Join(", ", text.Where(w => w.Length < 5 && w != "").OrderBy(w => w).Distinct()));
        }
    }
}
