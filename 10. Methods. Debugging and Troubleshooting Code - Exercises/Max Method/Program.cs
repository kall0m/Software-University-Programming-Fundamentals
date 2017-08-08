using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            BiggestNumOfThreeNums();
        }

        static int GetMax(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void BiggestNumOfThreeNums()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(num1, num2), num3));
        }
    }
}
