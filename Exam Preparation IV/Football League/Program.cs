using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var teams = Console.ReadLine();

            var teamScore = new Dictionary<string, int>();

            while(teams != "final")
            {
                var teamsTokens = teams.Split();

                var firstOccOfKeyIndex = teamsTokens[0].IndexOf(key);
                var team1Name = teamsTokens[0].Substring(firstOccOfKeyIndex);
                team1Name = new string(team1Name.Skip(key.Length).ToArray());
                team1Name = new string(team1Name.Reverse().ToArray());
                firstOccOfKeyIndex = team1Name.IndexOf(new string(key.Reverse().ToArray()));
                //team1Name = team1Name.Substring();
                //var team1Name = new string(team1Name.Skip(key.Length).ToArray());
                team1Name = new string(team1Name.Skip(key.Length).ToArray());
                team1Name = new string(team1Name.Reverse().ToArray().Skip(key.Length).ToArray()).ToUpper();

                var team2Name = new string(teamsTokens[1].Skip(key.Length).ToArray());
                team2Name = new string(team2Name.Reverse().ToArray().Skip(key.Length).ToArray()).ToUpper();

                var team1Score = int.Parse(teamsTokens[2].Split(':').First());
                var team2Score = int.Parse(teamsTokens[2].Split(':').Last());

                if(team1Score == team2Score)
                {
                    team1Score = 1;
                    team2Score = 1;
                }
                else if(team1Score > team2Score)
                {
                    team1Score = 3;
                    team2Score = 0;
                }
                else
                {
                    team2Score = 3;
                    team1Score = 0;
                }

                teamScore.Add(team1Name, team1Score);
                teamScore.Add(team2Name, team2Score);

                teams = Console.ReadLine();
            }
        }
    }
}
