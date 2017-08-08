using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    length++;
                }
                else
                {
                    start = i + 1;
                    length = 1;
                }

                if(bestLength < length)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
