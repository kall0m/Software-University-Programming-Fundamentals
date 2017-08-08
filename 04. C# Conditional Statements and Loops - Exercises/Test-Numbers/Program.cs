using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= boundary)
                    {
                        break;
                    }
                    sum += i * j * 3;
                    combinations++;
                }
                /*if (sum >= boundary)
                {
                    break;
                }*/
            }

            if (sum >= boundary)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {boundary}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
