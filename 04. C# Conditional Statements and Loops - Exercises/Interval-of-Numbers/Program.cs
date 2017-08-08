using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int larger = num1;
            int smaller = num2;

            if(num2 > num1)
            {
                larger = num2;
                smaller = num1;
            }

            for (int i = smaller; i <= larger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
