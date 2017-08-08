using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var longestIncreasingSubsequence = FindLongestIncreasingSubsequence(nums);

            Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
        }

        static List<int> FindLongestIncreasingSubsequence(List<int> nums)
        {
            var lengths = new int[nums.Count];
            var previous = new int[nums.Count];

            var bestLength = 0;
            var lastIndex = -1;

            for (int anchor = 0; anchor < nums.Count; anchor++)
            {
                lengths[anchor] = 1;
                previous[anchor] = -1;

                var anchorNum = nums[anchor];

                for (int i = 0; i < anchor; i++)
                {
                    var currentNum = nums[i];

                    if(currentNum < anchorNum)
                    {
                        if (lengths[anchor] < lengths[i] + 1)
                        {
                            lengths[anchor] = lengths[i] + 1;
                            previous[anchor] = i;
                        }
                    }
                }

                if(bestLength < lengths[anchor])
                {
                    bestLength = lengths[anchor];
                    lastIndex = anchor;
                }
            }

            var longestIncreasingSubsequence = new List<int>();

            while(lastIndex != -1)
            {
                longestIncreasingSubsequence.Add(nums[lastIndex]);
                lastIndex = previous[lastIndex];
            }

            longestIncreasingSubsequence.Reverse();

            return longestIncreasingSubsequence;
        }
    }
}
