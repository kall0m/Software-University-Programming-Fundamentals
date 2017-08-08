using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            var names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, regex);

            var validNames = new List<string>();

            foreach (Match m in matches)
            {
                validNames.Add(m.Value);
            }

            Console.WriteLine(string.Join(" ", validNames));
        }
    }
}
