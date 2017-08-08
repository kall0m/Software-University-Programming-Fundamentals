using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word1 = Console.ReadLine().Split(' ').ToArray();
            string[] word2 = Console.ReadLine().Split(' ').ToArray();

            int lenOfShorterString = word1.Length;

            if(lenOfShorterString > word2.Length)
            {
                lenOfShorterString = word2.Length;
            }

            int equalElements = 0;

            if(word1[0] != word2[0])
            {
                Array.Reverse(word1);
                Array.Reverse(word2);
            }

            for (int i = 0; i < lenOfShorterString; i++)
            {
                if(word1[i] == word2[i])
                {
                    equalElements++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(equalElements);
        }
    }
}
