using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    class Program
    {
        class Event
        {
            public string EventName { get; set; }
            public List<string> Participants = new List<string>();
            public int ParticipantsCount
            {
                get
                {
                    return Participants.Distinct().ToList().Count;
                }
            }
        }

        static void Main(string[] args)
        {
            var eventsByID = new Dictionary<int, Event>();

            var request = Console.ReadLine();

            while(request != "Time for Code")
            {
                var requestTokens = request.Split().Where(r => r != "").ToArray();

                var id = int.Parse(requestTokens[0]);
                var eventName = requestTokens[1];
                var participantsNames = requestTokens.Skip(2).Take(requestTokens.Length - 2).ToList();

                if (eventName.First() != '#')
                {
                    request = Console.ReadLine();
                    continue;
                }

                eventName = new string(eventName.Skip(1).ToArray());

                if (eventsByID.ContainsKey(id))
                {
                    if(eventsByID[id].EventName == eventName)
                    {
                        eventsByID[id].Participants.AddRange(participantsNames);
                    }
                    else
                    {
                        request = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    var ev = new Event
                    {
                        EventName = eventName,
                        Participants = participantsNames
                    };

                    eventsByID.Add(id, ev);
                }

                request = Console.ReadLine();
            }

            foreach (var ev in eventsByID.Values.OrderByDescending(p => p.ParticipantsCount).ThenBy(p => p.EventName))
            {
                Console.WriteLine($"{ev.EventName} - {ev.ParticipantsCount}");

                foreach (var participant in ev.Participants.OrderBy(p => p).Distinct())
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
