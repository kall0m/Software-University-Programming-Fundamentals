using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToUpper();

            var lettersPattern = @"(?<letters>[^0-9]+)";
            var numsPattern = @"(?<nums>[0-9]+)";

            var strings = Regex.Matches(text, lettersPattern);
            var nums = Regex.Matches(text, numsPattern);

            var rageMessage = new StringBuilder();
            var letters = new List<string>();
            var numbers = new List<int>();

            foreach (Match n in nums)
            {
                numbers.Add(int.Parse(n.Value));
            }

            var currNumIndex = 0;

            foreach (Match s in strings)
            {
                for (int i = 0; i < numbers[currNumIndex]; i++)
                {
                    rageMessage.Append(s.Value);
                }
                currNumIndex++;
            }

            Console.WriteLine($"Unique symbols used: {rageMessage.ToString().Distinct().Count()}");
            Console.WriteLine(rageMessage.ToString());
        }
    }
}
