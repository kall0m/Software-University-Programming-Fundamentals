using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> squares = new List<double>();

            foreach (var num in nums)
            {
                if(Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }

            squares.Sort();
            squares.Reverse();

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
