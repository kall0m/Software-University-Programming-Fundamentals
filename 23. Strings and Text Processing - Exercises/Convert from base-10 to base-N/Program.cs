using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            var baseN = numbers[0];

            var base10 = numbers[1];

            var result = new StringBuilder();

            while(base10 != 0)
            {
                result.Append(base10 % baseN);

                base10 /= baseN;
            }

            var reversedResult = new string(result.ToString().Reverse().ToArray());

            Console.WriteLine(reversedResult);
        }
    }
}
