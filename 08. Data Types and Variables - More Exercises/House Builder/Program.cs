using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(num1, num2) * 10 + Math.Min(num1, num2) * 4);
        }
    }
}
