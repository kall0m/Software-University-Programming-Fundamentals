using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorialOfN(n));
        }

        static BigInteger CalculateFactorialOfN(BigInteger n)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorialOfN(n - 1);
            }
        }
    }
}
