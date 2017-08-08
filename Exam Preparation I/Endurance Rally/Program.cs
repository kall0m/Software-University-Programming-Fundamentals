using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class Program
    {
        class Participant
        {
            public string Name { get; set; }
            public double Fuel { get; set; }
        }

        static void Main(string[] args)
        {
            var participantsNames = Console.ReadLine().Split();
            var trackLayout = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var participants = new List<Participant>();

            for (int i = 0; i < participantsNames.Length; i++)
            {
                var participant = new Participant
                {
                    Name = participantsNames[i],
                    Fuel = participantsNames[i].First()
                };

                participants.Add(participant);
            }

            foreach (var participant in participants)
            {
                var raceFinished = true;

                for (int i = 0; i < trackLayout.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        participant.Fuel += trackLayout[i];
                    }
                    else
                    {
                        participant.Fuel -= trackLayout[i];
                    }

                    if(participant.Fuel <= 0)
                    {
                        Console.WriteLine($"{participant.Name} - reached {i}");
                        raceFinished = false;
                        break;
                    }
                }

                if (raceFinished)
                {
                    Console.WriteLine($"{participant.Name} - fuel left {participant.Fuel:F2}");
                }
            }
            
        }
    }
}
