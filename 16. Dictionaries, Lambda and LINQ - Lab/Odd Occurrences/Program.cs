using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();

            var dict = new Dictionary<string, int>();

            foreach (var w in words)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }

            var odds = new List<string>();

            foreach (var pair in dict)
            {
                if(pair.Value % 2 != 0)
                {
                    odds.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", odds));
        }
    }
}
