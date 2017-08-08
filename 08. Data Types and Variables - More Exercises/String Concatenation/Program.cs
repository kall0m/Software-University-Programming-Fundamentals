using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = char.Parse(Console.ReadLine());
            string natureOfNumber = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string resultString = "";

            for (int i = 1; i <= numberOfLines; i++)
            {
                string word = Console.ReadLine();
                if(natureOfNumber == "odd" && i % 2 != 0)
                {
                    resultString += word + separator;
                }
                else if(natureOfNumber == "even" && i % 2 == 0)
                {
                    resultString += word + separator;
                }
            }

            Console.WriteLine(resultString.Remove(resultString.Length - 1));
        }
    }
}
