using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> nums = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            Console.WriteLine(string.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
