using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            for (int i = 0; i < arr[1]; i++)
            {
                nums.Remove(nums[0]);
            }

            bool found = false;

            foreach (var num in nums)
            {
                if(num == arr[2])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
