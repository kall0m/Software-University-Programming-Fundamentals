using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var userIP = new SortedDictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var info = input.Split();

                var ip = info.First().Split('=').Last();
                var user = info.Last().Split('=').Last();

                if (userIP.ContainsKey(user))
                {
                    if (!userIP[user].ContainsKey(ip))
                    {
                        userIP[user][ip] = 1;
                    }
                    else
                    {
                        userIP[user][ip]++;
                    }
                }
                else
                {
                    userIP.Add(user, new Dictionary<string, int>());
                    userIP[user][ip] = 1;
                }

                input = Console.ReadLine();
            }

            foreach (var user in userIP.Keys)
            {
                Console.WriteLine($"{user}:");

                foreach (var ip in userIP[user])
                {
                    if(ip.Key == userIP[user].Keys.Last())
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                }
            }
        }
    }
}
