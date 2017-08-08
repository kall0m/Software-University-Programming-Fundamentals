using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();

            int count = 1;

            for (int i = 0; i < nums.Count; i++)
            {
                if (i + 1 < nums.Count && nums[i] == nums[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{nums[i]} -> {count}");
                    count = 1;
                }
            }
        }
    }
}
