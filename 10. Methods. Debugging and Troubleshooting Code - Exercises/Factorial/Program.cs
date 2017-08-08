using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));
        }

        static BigInteger Factorial(BigInteger number)
        {
            if(number == 0)
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
