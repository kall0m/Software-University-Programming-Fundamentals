using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = nums.Length / 4;

            int[] left = nums.Take(k).Reverse().ToArray();
            int[] right = nums.Reverse().Take(k).ToArray();
            int[] row1 = left.Concat(right).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();

            for (int i = 0; i < k; i++)
            {
                row2[i] += row1[i];
            }

            for (int i = k; i < row2.Length; i++)
            {
                row2[i] += row1[i];
            }

            Console.WriteLine(string.Join(" ", row2));
        }
    }
}
