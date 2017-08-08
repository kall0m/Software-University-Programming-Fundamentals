using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsWithLetters = Console.ReadLine().Split().Where(c => c != "").ToArray();

            var finalResult = 0.0;

            for (int i = 0; i < numsWithLetters.Length; i++)
            {
                var resultForCurrentString = 0.0;

                var numsWithLettersChars = numsWithLetters[i].Trim();

                var letterBeforeNum = numsWithLettersChars.First();
                var letterAfterNum = numsWithLettersChars.Last();
                var numBetweenLetters = double.Parse(new string(numsWithLettersChars.Skip(1).TakeWhile(c => c < 'A').ToArray()));

                if (letterBeforeNum >= 'A' && letterBeforeNum <= 'Z')
                {
                    resultForCurrentString += numBetweenLetters / (letterBeforeNum - 'A' + 1);
                }
                else if(letterBeforeNum >= 'a' && letterBeforeNum <= 'z')
                {
                    resultForCurrentString += numBetweenLetters * (letterBeforeNum - 'a' + 1);
                }

                if (letterAfterNum >= 'A' && letterAfterNum <= 'Z')
                {
                    resultForCurrentString -= letterAfterNum - 'A' + 1;
                }
                else if (letterAfterNum >= 'a' && letterAfterNum <= 'z')
                {
                    resultForCurrentString += letterAfterNum - 'a' + 1;
                }

                finalResult += resultForCurrentString;
            }

            Console.WriteLine("{0:F2}", finalResult);
        }
    }
}
