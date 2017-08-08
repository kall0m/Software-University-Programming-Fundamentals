using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            Console.WriteLine($"Min = {GetMinElement(array)}");
            Console.WriteLine($"Max = {GetMaxElement(array)}");
            Console.WriteLine($"Sum = {GetSumOfElements(array)}");
            Console.WriteLine($"Average = {GetAverageValueOfElements(array)}");
        }

        static long GetMinElement(long[] arr)
        {
            long min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static long GetMaxElement(long[] arr)
        {
            long max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static long GetSumOfElements(long[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static double GetAverageValueOfElements(long[] arr)
        {
            return GetSumOfElements(arr) / (double)arr.Length;
        }
    }
}
