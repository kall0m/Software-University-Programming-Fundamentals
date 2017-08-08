using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seqOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int freq;
            int maxFreq = 0;
            int mostFreqNum = seqOfNums[0];

            for (int i = 0; i < seqOfNums.Length; i++)
            {
                freq = 0;

                for (int j = i + 1; j < seqOfNums.Length; j++)
                {
                    if(seqOfNums[i] == seqOfNums[j])
                    {
                        freq++;

                        if(maxFreq < freq)
                        {
                            mostFreqNum = seqOfNums[i];
                            maxFreq = freq;
                        }
                    }
                }
            }

            Console.WriteLine(mostFreqNum);
        }
    }
}
