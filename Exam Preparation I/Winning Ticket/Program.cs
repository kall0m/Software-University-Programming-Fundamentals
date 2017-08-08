using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Regex.Matches(Console.ReadLine(), @"[^\s,]+");

            foreach (Match ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var match = Regex.Match(ticket.Value, @"^(@|#|\$|\^)\1{19}$");

                if (match.Success)
                {
                    Console.WriteLine($"ticket \"{match.Value}\" - 10{match.Value[0]} Jackpot!");
                    continue;
                }

                var pattern = @"([@|#|$|^])\1{5,}";

                var leftHalf = Regex.Match(ticket.Value.Substring(0, 10), pattern);
                var rightHalf = Regex.Match(ticket.Value.Substring(10, 10), pattern);

                if(leftHalf.Success && rightHalf.Success && leftHalf.Value[0] == rightHalf.Value[0])
                {
                    Console.WriteLine($"ticket \"{ticket.Value}\" - {Math.Min(leftHalf.Value.Length, rightHalf.Value.Length)}{leftHalf.Value[0]}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket.Value}\" - no match");
                }
            }
        }
    }
}
