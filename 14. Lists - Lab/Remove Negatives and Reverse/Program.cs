using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> nonNegatives = new List<int>();

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] >= 0)
                {
                    nonNegatives.Add(nums[i]);
                }
            }

            if(nonNegatives.Count > 0)
            {
                Console.WriteLine(String.Join(" ", nonNegatives));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
