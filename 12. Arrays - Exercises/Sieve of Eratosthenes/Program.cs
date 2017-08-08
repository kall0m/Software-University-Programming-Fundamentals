using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool[] primes = new bool[n + 1];

            for (int i = 2; i <= n; i++)
            {
                primes[i] = true;
            }

            for (int p = 0; p <= n; p++)
            {
                if (primes[p])
                {
                    Console.Write($"{p} ");

                    for (int i = p; i <= n / p; i++)
                    {
                        primes[p * i] = false;
                    }

                }
            }
        }
    }
}
