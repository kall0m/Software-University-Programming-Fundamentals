using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1Digits = Console.ReadLine().TrimStart('0').ToArray().Select(c => ulong.Parse(c.ToString())).Reverse().ToList();
            var num2Digits = Console.ReadLine().TrimStart('0').ToArray().Select(c => ulong.Parse(c.ToString())).Reverse().ToList();

            if (num1Digits.Count == 0 && num2Digits.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var smallerNumLen = num1Digits.Count < num2Digits.Count ? num1Digits.Count : num2Digits.Count;

            var sum = new List<ulong>();

            for (int i = 0; i < smallerNumLen; i++)
            {
                sum.Add(num1Digits[i] + num2Digits[i]);
            }

            if(num1Digits.Count > num2Digits.Count)
            {
                for (int i = num2Digits.Count; i < num1Digits.Count; i++)
                {
                    sum.Add(num1Digits[i]);
                }
            }
            else
            {
                for (int i = num1Digits.Count; i < num2Digits.Count; i++)
                {
                    sum.Add(num2Digits[i]);
                }
            }

            for (int i = 0; i < sum.Count - 1; i++)
            {
                if(sum[i] > 9)
                {
                    sum[i] = sum[i] % 10;

                    sum[i + 1]++;
                }
            }

            sum.Reverse();            

            Console.WriteLine(string.Join("", sum));
        }
    }
}
