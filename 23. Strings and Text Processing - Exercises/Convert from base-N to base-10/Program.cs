using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();

            var baseN = numbers[0];
            var numToConvert = numbers[1];

            BigInteger result = 0;

            var power = 0;

            while (numToConvert != 0)
            {
                var digit = numToConvert % 10;

                result += digit * PowerOfNum(baseN, power++);

                numToConvert /= 10;
            }

            Console.WriteLine(result);
        }

        static BigInteger PowerOfNum(BigInteger num, int pow)
        {
            BigInteger result = num;

            if(pow == 0)
            {
                return 1;
            }

            for (int i = 1; i < pow; i++)
            {
                result *= num;
            }

            return result;
        }
    }
}
