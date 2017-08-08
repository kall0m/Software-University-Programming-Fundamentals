using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();

            var str1 = strings[0];
            var str2 = strings[1];

            var sum = CalcMultOfCharCodes(str1, str2);

            Console.WriteLine(sum);
        }

        static long CalcMultOfCharCodes(string str1, string str2)
        {
            var sum = 0;

            if (str1.Length > str2.Length)
            {
                var charArr = str1.Skip(str2.Length).ToArray();

                for (int i = 0; i < charArr.Length; i++)
                {
                    sum += charArr[i];
                }
            }
            else if (str1.Length < str2.Length)
            {
                var charArr = str2.Skip(str1.Length).ToArray();

                for (int i = 0; i < charArr.Length; i++)
                {
                    sum += charArr[i];
                }
            }

            var minLen = str1.Length;

            if(minLen > str2.Length)
            {
                minLen = str2.Length;
            }

            for (int i = 0; i < minLen; i++)
            {
                sum += str1[i] * str2[i];
            }

            return sum;
        }
    }
}
