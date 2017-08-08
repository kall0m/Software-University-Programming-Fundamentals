using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());

            string sms = "";

            for (int i = 0; i < numberOfCharacters; i++)
            {
                int numTextChar = int.Parse(Console.ReadLine());

                if(numTextChar == 0)
                {
                    sms += (char)32;
                    continue;
                }

                int mainDigitOfNum = numTextChar % 10;

                int numberOfDigits = 0;
                while(numTextChar % 10 != 0)
                {
                    numberOfDigits++;
                    numTextChar /= 10;
                }

                int offsetOfNum = (mainDigitOfNum - 2) * 3;

                if(mainDigitOfNum == 8 || mainDigitOfNum == 9)
                {
                    offsetOfNum++;
                }

                char letterIndex = (char)(offsetOfNum + numberOfDigits - 1 + 'a');

                sms += letterIndex; 
            }

            Console.WriteLine(sms);
        }
    }
}
