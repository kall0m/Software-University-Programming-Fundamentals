using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ').ToList();

            List<string> puretext = new List<string>();

            foreach (var word in text)
            {
                if(word != "")
                {
                    puretext.Add(word);
                }
            }

            /*for (int i = 0; i < text.Count; i++)
            {
                if (text[i] == "")
                {
                    text.Remove(text[i]);
                    i--;
                }
            }*/

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            int lowerCaseCount;
            int upperCaseCount;

            for (int i = 0; i < puretext.Count; i++)
            {
                lowerCaseCount = puretext[i].Length;
                upperCaseCount = puretext[i].Length;

                for (int j = 0; j < puretext[i].Length; j++)
                {
                    if (puretext[i][j] >= 'a' && puretext[i][j] <= 'z')
                    {
                        upperCaseCount--;
                    }
                    else if (puretext[i][j] >= 'A' && puretext[i][j] <= 'Z')
                    {
                        lowerCaseCount--;
                    }
                }

                if(lowerCaseCount == 0)
                {
                    upperCase.Add(puretext[i]);
                }
                else if(upperCaseCount == 0)
                {
                    lowerCase.Add(puretext[i]);
                }
                else
                {
                    mixedCase.Add(puretext[i]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
