using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        class Participant
        {
            public string Name { get; set; }
            public List<string> Awards { get; set; }
            public int AwardsCount
            {
                get
                {
                    return Awards.Count;
                }
            }
        }

        static void Main(string[] args)
        {
            var participantsAppliedForPerformance = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
            var availableSongs = Console.ReadLine().Split(',').Select(s => s.Trim()).ToList();

            var performance = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();

            var participants = new Dictionary<string, Participant>();

            while(performance[0] != "dawn")
            {
                var participantName = performance[0];
                var song = performance[1];
                var award = performance[2];

                if(availableSongs.Contains(song) && participantsAppliedForPerformance.Contains(participantName))
                {
                    var participant = new Participant
                    {
                        Name = participantName,
                        Awards = new List<string>()
                    };

                    if (!participants.ContainsKey(participant.Name))
                    {
                        participants.Add(participant.Name, participant);
                    }

                    if (!participants[participant.Name].Awards.Contains(award))
                    {
                        participants[participant.Name].Awards.Add(award);
                    }
                }

                performance = Console.ReadLine().Split(',').Select(p => p.Trim()).ToList();
            }

            foreach (var participant in participants.Values.OrderByDescending(p => p.AwardsCount).ThenBy(p => p.Name))
            {
                Console.WriteLine($"{participant.Name}: {participant.AwardsCount} awards");

                foreach (var award in participant.Awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }

            if(participants.Count == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
