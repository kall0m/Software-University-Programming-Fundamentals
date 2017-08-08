using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= numbers; currentNum++)
            {
                bool isPrime = true;

                for (int checkIsPrime = 2; checkIsPrime <= Math.Sqrt(currentNum); checkIsPrime++)
                {
                    if (currentNum % checkIsPrime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{currentNum} -> {isPrime}");
            }
        }
    }
}
