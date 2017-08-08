using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var venues = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine().Split('@');

            while (input[0] != "End")
            {
                try
                {
                    var singer = input.First();

                    if(singer.Last() == ' ')
                    {
                        singer = input.First().Trim();
                    }
                    else
                    {
                        input = Console.ReadLine().Split('@');
                        continue;
                    }

                    var rightPart = input.Last().TakeWhile(x => x < '0' || x > '9').ToArray();

                    var venue = string.Join("", rightPart).Trim();

                    var ticketsCountAndPrice = input.Last().Split().Reverse().Take(2).ToArray();

                    var money = long.Parse(ticketsCountAndPrice[0]) * long.Parse(ticketsCountAndPrice[1]);

                    if (!venues.ContainsKey(venue))
                    {
                        venues.Add(venue, new Dictionary<string, long>());
                    }

                    if (!venues[venue].ContainsKey(singer))
                    {
                        venues[venue].Add(singer, money);
                    }
                    else
                    {
                        venues[venue][singer] += money;
                    }
                }
                catch
                {
                    
                }

                input = Console.ReadLine().Split('@');
            }

            foreach (var venue in venues)
            {
                Console.WriteLine($"{venue.Key}");

                foreach (var singer in venues[venue.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
