using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum;
            int rightSum;

            for (int i = 0; i < array.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += array[j];
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
