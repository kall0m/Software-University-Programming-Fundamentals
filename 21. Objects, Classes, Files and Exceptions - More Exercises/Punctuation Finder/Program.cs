using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("sample_text.txt");

            var output = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] punctuationMarks = { '.', ',', '!', '?', ':' };

                var text = input[i];

                foreach (var symbol in text.Where(s => punctuationMarks.Contains(s)))
                {
                    output.Add(symbol);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
