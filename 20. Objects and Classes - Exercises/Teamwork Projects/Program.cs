using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork_Projects
{
    class Program
    {
        class Team
        {
            public string Name { get; set; }
            public List<string> Members { get; set; }
            public string Creator { get; set; }
        }

        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = ReadTeams();

            PrintTeams(teams);
        }

        static void PrintTeams(Dictionary<string, Team> teams)
        {
            foreach (var team in teams.Where(t => t.Value.Members.Count != 0).OrderByDescending(t => t.Value.Members.Count).ThenBy(t => t.Key))
            {
                Console.WriteLine(team.Key);

                Console.WriteLine($"- {team.Value.Creator}");

                foreach (var member in team.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.Where(t => t.Value.Members.Count == 0).OrderBy(t => t.Key))
            {
                Console.WriteLine(team.Key);
            }
        }

        static Dictionary<string, Team> ReadTeams()
        {
            int n = int.Parse(Console.ReadLine());

            var teams = new Dictionary<string, Team>();

            for (int i = 0; i < n; i++)
            {
                var teamInfo = Console.ReadLine().Split('-');
                var creator = teamInfo[0];
                var teamName = teamInfo[1];

                if (!teams.ContainsKey(teamName))
                {
                    teams[teamName] = new Team();

                    if (teams[teamName].Creator != creator)
                    {
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");

                        teams[teamName].Creator = creator;
                        teams[teamName].Name = teamName;
                        teams[teamName].Members = new List<string>();
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            var users = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (users[0] != "end of assignment")
            {
                var user = users[0];
                var teamName = users[1];

                if (teams.ContainsKey(teamName))
                {
                    if (!teams[teamName].Members.Contains(user) && teams[teamName].Creator != user)
                    {
                        teams[teamName].Members.Add(user);
                    }
                    else
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }

                users = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return teams;
        }
    }
}
