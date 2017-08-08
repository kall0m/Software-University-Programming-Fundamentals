using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int search = int.Parse(Console.ReadLine());

            int indexOfSearch = FindLastOcc(array, search);

            long sum = 0;
            bool searchFound = false;

            for (int i = 0; i < indexOfSearch; i++)
            {
                searchFound = true;
                sum += array[i];
            }

            if (searchFound)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }

        static int FindLastOcc(long[] arr, int search)
        {
            int indexOfSearch = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == search)
                {
                    indexOfSearch = i;
                }
            }

            return indexOfSearch;
        }
    }
}
