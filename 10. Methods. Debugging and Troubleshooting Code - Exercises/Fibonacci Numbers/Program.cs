using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(num));
        }

        static int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
