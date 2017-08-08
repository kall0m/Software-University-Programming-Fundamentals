using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine().TrimStart('0').ToArray().Select(c => int.Parse(c.ToString())).Reverse().ToList();
            var num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            var sum = new List<int>();

            for (int i = 0; i < num1.Count; i++)
            {
                sum.Add(num1[i] * num2);
            }

            for (int i = 0; i < sum.Count - 1; i++)
            {
                if(sum[i] > 9)
                {
                    sum[i + 1] += sum[i] / 10;
                    sum[i] %= 10;
                }
            }

            sum.Reverse();

            Console.WriteLine(string.Join("", sum));
        }
    }
}
