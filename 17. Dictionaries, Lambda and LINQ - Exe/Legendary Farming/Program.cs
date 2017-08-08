using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterials = new SortedDictionary<string, long>();
            var junkMaterials = new SortedDictionary<string, long>();

            var input = Console.ReadLine().ToLower().Split().ToList();

            bool found = false;

            while (true)
            {
                for (int i = 1; i < input.Count; i += 2)
                {
                    switch (input[i])
                    {
                        case "shards":
                        case "fragments":
                        case "motes":
                            if (!keyMaterials.ContainsKey(input[i]))
                            {
                                keyMaterials[input[i]] = long.Parse(input[i - 1]);
                            }
                            else
                            {
                                keyMaterials[input[i]] += long.Parse(input[i - 1]);
                            }

                            if (keyMaterials[input[i]] >= 250)
                            {
                                switch (input[i])
                                {
                                    case "shards": Console.WriteLine($"Shadowmourne obtained!"); break;
                                    case "fragments": Console.WriteLine($"Valanyr obtained!"); break;
                                    case "motes": Console.WriteLine($"Dragonwrath obtained!"); break;
                                }

                                keyMaterials[input[i]] -= 250;

                                found = true;
                            }
                            break;
                        default:
                            if (!junkMaterials.ContainsKey(input[i]))
                            {
                                junkMaterials[input[i]] = long.Parse(input[i - 1]);
                            }
                            else
                            {
                                junkMaterials[input[i]] += long.Parse(input[i - 1]);
                            }
                            break;
                    }

                    if (found)
                    {
                        break;
                    }
                }

                if (found)
                {
                    break;
                }

                input = Console.ReadLine().ToLower().Split().ToList();
            }

            if (!(keyMaterials.ContainsKey("shards")))
            {
                keyMaterials["shards"] = 0;
            }
            if (!(keyMaterials.ContainsKey("fragments")))
            {
                keyMaterials["fragments"] = 0;
            }
            if (!(keyMaterials.ContainsKey("motes")))
            {
                keyMaterials["motes"] = 0;
            }

            foreach (var keyMaterial in keyMaterials.OrderByDescending(kmat => kmat.Value))
            {
                Console.WriteLine($"{keyMaterial.Key}: {keyMaterial.Value}");
            }

            foreach (var junkMaterial in junkMaterials)
            {
                Console.WriteLine($"{junkMaterial.Key}: {junkMaterial.Value}");
            }
        }
    }
}
