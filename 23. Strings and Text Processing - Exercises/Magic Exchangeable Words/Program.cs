using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();

            var str1 = strings[0];
            var str2 = strings[1];

            Boolean areExchangeable = AreExchangeable(str1, str2);

            Console.WriteLine(areExchangeable ? "true" : "false");
        }

        static bool AreExchangeable(string str1, string str2)
        {
            var minLen = str1.Length < str2.Length ? str1.Length : str2.Length;

            if (str1.Distinct().ToArray().Length != str2.Distinct().ToArray().Length)
            {
                return false;
            }

            var charRegister = new Dictionary<char, char>();

            for (int i = 0; i < minLen; i++)
            {
                if (!charRegister.ContainsKey(str1[i]))
                {
                    charRegister[str1[i]] = str2[i];
                }
                else if(charRegister[str1[i]] != str2[i])
                {
                    return false;
                }
            }

            if(str1.Length > str2.Length)
            {
                for (int i = str2.Length; i < str1.Length; i++)
                {
                    if (!charRegister.ContainsKey(str1[i]))
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = str1.Length; i < str2.Length; i++)
                {
                    if (!charRegister.ContainsValue(str2[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
