using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalHealthPattern = @"[^0-9\+\-\*\/\.]";
            var totalDamagePattern = @"(\-|\+)?([0-9]+\.)?[0-9]+";

            var demonMatches = Regex.Matches(Console.ReadLine(), @"[^\s,]+");

            var demons = new List<string>();

            foreach (Match demon in demonMatches)
            {
                demons.Add(demon.Value);
            }

            foreach (var demon in demons.OrderBy(d => d))
            {
                var demonHealthSymbols = Regex.Matches(demon, totalHealthPattern);
                var totalDemonHealth = 0;

                foreach (Match symbol in demonHealthSymbols)
                {
                    totalDemonHealth += symbol.Value.ToCharArray().First();
                }

                var demonDamageSymbols = Regex.Matches(demon, totalDamagePattern);
                var totalDemonDamage = 0.0;

                foreach (Match symbol in demonDamageSymbols)
                {
                    totalDemonDamage += double.Parse(symbol.Value);
                }

                var multiplyCount = 0;
                var divideCount = 0;

                foreach (var symbol in demon)
                {
                    if(symbol == '*')
                    {
                        multiplyCount++;
                    }
                    else if(symbol == '/')
                    {
                        divideCount++;
                    }
                }

                for (int i = 0; i < multiplyCount; i++)
                {
                    totalDemonDamage *= 2;
                }

                for (int i = 0; i < divideCount; i++)
                {
                    totalDemonDamage /= 2;
                }

                Console.WriteLine($"{demon} - {totalDemonHealth} health, {totalDemonDamage:f2} damage");
            }
        }
    }
}
