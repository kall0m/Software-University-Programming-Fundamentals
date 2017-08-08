using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
