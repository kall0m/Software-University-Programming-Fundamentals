using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int len = 1;
            int bestStart = start;
            int bestLen = len;

            for (int pos = 1; pos <= seq.Length - 1; pos++)
            {
                if (seq[pos - 1] < seq[pos])
                {
                    len++;

                    if (bestLen < len)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }
                else
                {
                    start = pos;
                    len = 1;
                }
            }

            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write(seq[i] + " ");
            }
        }
    }
}
