using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ', ',', '.', '?', '!').Where(c => c != "");

            var palindromes = new List<string>();

            foreach (var word in words)
            {
                var reversedWord = word.ToCharArray();

                Array.Reverse(reversedWord);

                if(new string(reversedWord) == word && !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(w => w)));
        }
    }
}
