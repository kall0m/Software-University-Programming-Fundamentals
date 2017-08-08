using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<string> > >();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var dragonType = input[0];
                var dragonName = input[1];
                var dragonStats = new List<string>();

                for (int j = 2; j < 5; j++)
                {
                    dragonStats.Add(input[j]);
                }

                if (dragonStats[0] == "null")
                {
                    dragonStats[0] = "45";
                }

                if (dragonStats[1] == "null")
                {
                    dragonStats[1] = "250";
                }

                if (dragonStats[2] == "null")
                {
                    dragonStats[2] = "10";
                }

                if (!dragons.ContainsKey(dragonType))
                {
                    dragons[dragonType] = new SortedDictionary<string, List<string>>();
                }

                if (!dragons[dragonType].ContainsKey(dragonName))
                {
                    dragons[dragonType][dragonName] = dragonStats;
                }
                else
                {
                    //dragons[dragonType][dragonName].Clear();
                    dragons[dragonType][dragonName] = dragonStats;
                }
            }

            foreach (var dragonType in dragons)
            {
                var damages = new List<int>();
                var healths = new List<int>();
                var armors = new List<int>();

                foreach (var dragon in dragons[dragonType.Key])
                {
                    damages.Add(int.Parse(dragon.Value[0]));
                    healths.Add(int.Parse(dragon.Value[1]));
                    armors.Add(int.Parse(dragon.Value[2]));
                }

                Console.WriteLine($"{dragonType.Key}::({damages.Average():F2}/{healths.Average():F2}/{armors.Average():F2})");

                foreach (var dragon in dragons[dragonType.Key])
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
