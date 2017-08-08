using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var immuneSystem = new Dictionary<string, int>();

            var initialHealth = long.Parse(Console.ReadLine());

            var initialHealthBeforeVirus = initialHealth;

            var virus = Console.ReadLine();

            while(virus != "end")
            {
                var virusDefeatTimeInSeconds = 0;

                if (!immuneSystem.ContainsKey(virus))
                {
                    immuneSystem[virus] = CalculateVirusStrength(virus);

                    virusDefeatTimeInSeconds = immuneSystem[virus] * virus.Length;
                }
                else
                {
                    virusDefeatTimeInSeconds = (immuneSystem[virus] * virus.Length) / 3;
                }

                Console.WriteLine($"Virus {virus}: {immuneSystem[virus]} => {virusDefeatTimeInSeconds} seconds");

                if (virusDefeatTimeInSeconds >= initialHealth)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    initialHealth -= virusDefeatTimeInSeconds;
                }

                int virusDefeatTimeInMinutes = CalculateTimeInMinutesAndSeconds(ref virusDefeatTimeInSeconds);

                Console.WriteLine($"{virus} defeated in {virusDefeatTimeInMinutes}m {virusDefeatTimeInSeconds}s.");

                Console.WriteLine($"Remaining health: {initialHealth}");

                initialHealth = (long)(initialHealth * 1.2);

                if (initialHealth > initialHealthBeforeVirus)
                {
                    initialHealth = initialHealthBeforeVirus;
                }

                virus = Console.ReadLine();
            }

            Console.WriteLine($"Final Health: {initialHealth}");
        }

        static int CalculateTimeInMinutesAndSeconds(ref int virusDefeatTimeInSeconds)
        {
            var virusDefeatTimeInMinutes = 0;

            while (virusDefeatTimeInSeconds >= 60)
            {
                virusDefeatTimeInMinutes++;

                virusDefeatTimeInSeconds -= 60;
            }

            return virusDefeatTimeInMinutes;
        }

        static int CalculateVirusStrength(string virus)
        {
            var strength = 0;

            foreach (var ch in virus)
            {
                strength += ch;
            }

            strength = strength / 3;

            return strength;
        }
    }
}
