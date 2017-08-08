using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            DigitsOfNumInReversedOrder(num);
        }

        static void DigitsOfNumInReversedOrder(decimal num)
        {
            string numString = num.ToString();
            StringBuilder reversedNumString = new StringBuilder(numString);
            int j = 0;
            for(int i = numString.Length - 1; i >= 0; i--)
            {
                reversedNumString[j++] = numString[i];
            }
            Console.WriteLine(reversedNumString);
        }
    }
}
