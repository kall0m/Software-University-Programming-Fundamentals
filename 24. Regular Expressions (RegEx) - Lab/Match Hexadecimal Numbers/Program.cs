﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(0x)?[0-9A-F]+\b";

            var numbersStrings = Console.ReadLine();

            var numbers = Regex.Matches(numbersStrings, regex).Cast<Match>().Select(n => n.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
