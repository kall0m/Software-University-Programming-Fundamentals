using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] inputChars = input.ToCharArray();

            List<int> numbersList = inputChars.Where(n => char.IsDigit(n)).Select(n => int.Parse(n.ToString())).ToList();

            List<char> symbolsList = inputChars.Where(s => !char.IsDigit(s)).ToList();

            List<int> takeList = numbersList.Where((n, i) => i % 2 == 0).ToList();

            List<int> skipList = numbersList.Where((n, i) => i % 2 != 0).ToList();

            string resultString = "";

            int totalSkips = 0;

            for (int i = 0; i < skipList.Count; i++)
            {
                foreach (var character in symbolsList.Skip(totalSkips).Take(takeList[i]))
                {
                    resultString += character;
                }

                totalSkips += skipList[i] + takeList[i];
            }

            Console.WriteLine($"{resultString}");
        }
    }
}
