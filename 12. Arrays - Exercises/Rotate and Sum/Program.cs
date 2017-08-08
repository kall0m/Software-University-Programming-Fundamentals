using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElement = array[array.Length - 1];

                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }

                array[0] = lastElement;

                for (int j = 0; j < array.Length; j++)
                {
                    sum[j] = sum[j] + array[j];
                }
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
