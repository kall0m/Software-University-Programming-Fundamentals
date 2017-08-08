using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();

            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                char[] num = nums[i].ToCharArray().Reverse().ToArray();

                string reversed = new string(num);

                sum += int.Parse(reversed);
            }

            Console.WriteLine(sum);
        }
    }
}
