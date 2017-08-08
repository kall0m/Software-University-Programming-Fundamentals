using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string lowCaseWord = Console.ReadLine();

            for (int i = 0; i < lowCaseWord.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if(lowCaseWord[i] == alphabet[j])
                    {
                        Console.WriteLine($"{lowCaseWord[i]} -> {j}");
                    }
                }
            }
        }
    }
}
