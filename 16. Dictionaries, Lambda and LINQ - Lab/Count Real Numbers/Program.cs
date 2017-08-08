﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            var count = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            foreach (var pair in count)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
