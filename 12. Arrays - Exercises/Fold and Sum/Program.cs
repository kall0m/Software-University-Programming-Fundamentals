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
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            int[] firstKNums = new int[k];
            int[] lastKNums = new int[k];           

            for (int i = 0; i < k; i++)
            {
                firstKNums[i] = arr[i];
            }

            Array.Reverse(firstKNums);

            for (int i = 0; i < k; i++)
            {
                lastKNums[i] = arr[arr.Length - 1 - i];
            }

            int[] middle = new int[2 * k];

            for (int i = k, j = 0; i <= arr.Length - 1 - k; i++, j++)
            {
                middle[j] = arr[i];
            }

            int[] firstRow = new int[2 * k];
            firstKNums.CopyTo(firstRow, 0);
            lastKNums.CopyTo(firstRow, firstKNums.Length);

            int[] foldedSum = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                foldedSum[i] = middle[i] + firstRow[i];
            }

            Console.WriteLine(String.Join(" ", foldedSum));
        }
    }
}
