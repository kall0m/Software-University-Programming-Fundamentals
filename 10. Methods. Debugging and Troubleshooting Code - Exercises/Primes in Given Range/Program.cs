using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            string joined = string.Join(", ", FindPrimesInRange(num1, num2).ToArray());

            Console.WriteLine(joined);
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNums = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNums.Add(i);
                }
            }

            return primeNums;
        }

        static bool IsPrime(long n)
        {
            if (n == 0) return false;
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i <= Math.Floor(Math.Sqrt(n)); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
