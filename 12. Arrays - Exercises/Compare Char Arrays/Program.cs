using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] word2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int len1 = word1.Length;
            int len2 = word2.Length;
            int minLen = len1;
            char[] shorter = word1;
            char[] longer = word2;

            if(len1 > len2)
            {
                minLen = len2;
                shorter = word2;
                longer = word1;
            }

            for (int i = 0; i < minLen; i++)
            {
                if (word1[i] < word2[i])
                {
                    Console.WriteLine(word1);
                    Console.WriteLine(word2);
                    return;
                }
                else if (word1[i] > word2[i])
                {
                    Console.WriteLine(word2);
                    Console.WriteLine(word1);
                    return;
                }
            }

            Console.WriteLine(shorter);
            Console.WriteLine(longer);
        }
    }
}
