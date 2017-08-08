using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var ip = input.First();
                var user = input[1];
                var duration = int.Parse(input.Last());

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new SortedDictionary<string, int>();
                }

                if (logs[user].ContainsKey(ip))
                {
                    logs[user][ip] += duration;
                }
                else
                {
                    logs[user][ip] = duration;
                }
            }

            foreach (var user in logs)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", user.Value.Keys)}]");
            }
        }
    }
}
