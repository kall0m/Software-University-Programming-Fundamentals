using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Name_of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(EnglishNameOfLastDigit(num));
        }

        static string EnglishNameOfLastDigit(long num)
        {            
            long lastDigit = num % 10;
            string lastDigitWord = "";

            switch (lastDigit)
            {
                case 0: lastDigitWord = "zero"; break;
                case 1: lastDigitWord = "one"; break;
                case 2: lastDigitWord = "two"; break;
                case 3: lastDigitWord = "three"; break;
                case 4: lastDigitWord = "four"; break;
                case 5: lastDigitWord = "five"; break;
                case 6: lastDigitWord = "six"; break;
                case 7: lastDigitWord = "seven"; break;
                case 8: lastDigitWord = "eight"; break;
                case 9: lastDigitWord = "nine"; break;
            }

            return lastDigitWord;
        }
    }
}
