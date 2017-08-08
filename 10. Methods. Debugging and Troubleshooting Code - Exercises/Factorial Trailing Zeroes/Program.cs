using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(CountFactorialTrailingZeroes(num));
        }

        static int CountFactorialTrailingZeroes(BigInteger number)
        {
            int zeroes = 0;
            number = Factorial(number);

            while(number % 10 == 0)
            {
                zeroes++;
                number /= 10;
            }

            return zeroes;
        }

        static BigInteger Factorial(BigInteger number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
