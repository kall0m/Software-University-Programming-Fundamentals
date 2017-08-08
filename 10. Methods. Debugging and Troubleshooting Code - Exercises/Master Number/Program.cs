using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if(CheckIfPalindrome(i) && SumOfDigits(i) % 7 == 0 && CheckHoldsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool CheckHoldsEvenDigit(int number)
        {
            while(number > 0)
            {
                if((number % 10) % 2 == 0)
                {
                    return true;
                }
                else
                {
                    number /= 10;
                }
            }

            return false;
        }

        static int SumOfDigits(int number)
        {
            int sumOfDigits = 0;

            while(number > 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            return sumOfDigits;
        }

        static bool CheckIfPalindrome(int number)
        {
            string numberText = number.ToString();

            bool isPalindrome = false;

            for (int i = 0, j = numberText.Length - 1; i < numberText.Length / 2; i++, j--)
            {
                isPalindrome = false;
                if (numberText[i] == numberText[j])
                {
                    isPalindrome = true;
                }
                else
                {
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
