using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seqOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairs = 0;

            for (int i = 0; i < seqOfNums.Length; i++)
            {
                for (int j = i; j < seqOfNums.Length; j++)
                {
                    if(Math.Abs(seqOfNums[i] - seqOfNums[j]) == difference)
                    {
                        pairs++;
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
