using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Program
    {
        class Arm
        {
            public long EnergyConsumption { get; set; }
            public long Reach { get; set; }
            public long Fingers { get; set; }
        }

        class Leg
        {
            public long EnergyConsumption { get; set; }
            public long Strength { get; set; }
            public long Speed { get; set; }
        }

        class Torso
        {
            public long EnergyConsumption { get; set; }
            public double Processor { get; set; }
            public string HousingMaterial { get; set; }
        }

        class Head
        {
            public long EnergyConsumption { get; set; }
            public long IQ { get; set; }
            public string SkinMaterial { get; set; }
        }

        class Jarvis
        {
            public Head Head { get; set; }
            public Torso Torso { get; set; }
            public List<Arm> Arms = new List<Arm>();
            public List<Leg> Legs = new List<Leg>();
        }

        static void Main(string[] args)
        {
            var capacity = long.Parse(Console.ReadLine());

            Jarvis jarvis = new Jarvis();

            ReadJarvisComponents(jarvis);

            long totalEnergy = 0;

            if (jarvis.Head != null)
            {
                totalEnergy += jarvis.Head.EnergyConsumption;
            }

            if(jarvis.Torso != null)
            {
                totalEnergy += jarvis.Torso.EnergyConsumption;
            }

            foreach (var arm in jarvis.Arms)
            {
                totalEnergy += arm.EnergyConsumption;
            }

            foreach (var leg in jarvis.Legs)
            {
                totalEnergy += leg.EnergyConsumption;
            }

            if (totalEnergy > capacity)
            {
                Console.WriteLine("We need more power!");
                return;
            }

            if (jarvis.Head == null || jarvis.Torso == null || jarvis.Arms.Count != 2 || jarvis.Legs.Count != 2)
            {
                Console.WriteLine("We need more parts!");
                return;
            }

            PrintComponents(jarvis);
        }

        static void PrintComponents(Jarvis jarvis)
        {
            Console.WriteLine("Jarvis:");

            Console.WriteLine("#Head:");
            Console.WriteLine($"###Energy consumption: {jarvis.Head.EnergyConsumption}");
            Console.WriteLine($"###IQ: {jarvis.Head.IQ}");
            Console.WriteLine($"###Skin material: {jarvis.Head.SkinMaterial}");

            Console.WriteLine("#Torso:");
            Console.WriteLine($"###Energy consumption: {jarvis.Torso.EnergyConsumption}");
            Console.WriteLine($"###Processor size: {jarvis.Torso.Processor.ToString("0.0")}");
            Console.WriteLine($"###Corpus material: {jarvis.Torso.HousingMaterial}");

            foreach (var arm in jarvis.Arms.OrderBy(a => a.EnergyConsumption))
            {
                Console.WriteLine("#Arm:");
                Console.WriteLine($"###Energy consumption: {arm.EnergyConsumption}");
                Console.WriteLine($"###Reach: {arm.Reach}");
                Console.WriteLine($"###Fingers: {arm.Fingers}");
            }

            foreach (var leg in jarvis.Legs.OrderBy(l => l.EnergyConsumption))
            {
                Console.WriteLine("#Leg:");
                Console.WriteLine($"###Energy consumption: {leg.EnergyConsumption}");
                Console.WriteLine($"###Strength: {leg.Strength}");
                Console.WriteLine($"###Speed: {leg.Speed}");
            }
        }

        static void ReadJarvisComponents(Jarvis jarvis)
        {
            var component = Console.ReadLine().Split();

            while (component[0] != "Assemble!")
            {
                var compName = component[0];
                var compSpecs = component.Skip(1).ToList();

                switch (compName)
                {
                    case "Head":
                        ReadHead(compSpecs, jarvis);
                        break;
                    case "Torso":
                        ReadTorso(compSpecs, jarvis);
                        break;
                    case "Arm":
                        ReadArm(compSpecs, jarvis);
                        break;
                    case "Leg":
                        ReadLeg(compSpecs, jarvis);
                        break;
                }

                component = Console.ReadLine().Split();
            }
        }

        static void ReadLeg(List<string> compSpecs, Jarvis jarvis)
        {
            Leg leg = new Leg
            {
                EnergyConsumption = long.Parse(compSpecs[0]),
                Strength = long.Parse(compSpecs[1]),
                Speed = long.Parse(compSpecs[2])
            };

            jarvis.Legs.Add(leg);

            jarvis.Legs = jarvis.Legs.OrderBy(l => l.EnergyConsumption).ToList();

            if(jarvis.Legs.Count > 2)
            {
                jarvis.Legs = jarvis.Legs.Take(2).ToList();
            }
        }

        static void ReadArm(List<string> compSpecs, Jarvis jarvis)
        {
            Arm arm = new Arm
            {
                EnergyConsumption = long.Parse(compSpecs[0]),
                Reach = long.Parse(compSpecs[1]),
                Fingers = long.Parse(compSpecs[2])
            };

            jarvis.Arms.Add(arm);

            jarvis.Arms = jarvis.Arms.OrderBy(a => a.EnergyConsumption).ToList();

            if(jarvis.Arms.Count > 2)
            {
                jarvis.Arms = jarvis.Arms.Take(2).ToList();
            }
        }

        static void ReadTorso(List<string> compSpecs, Jarvis jarvis)
        {
            Torso torso = new Torso
            {
                EnergyConsumption = long.Parse(compSpecs[0]),
                Processor = double.Parse(compSpecs[1]),
                HousingMaterial = compSpecs[2]
            };

            if(jarvis.Torso == null)
            {
                jarvis.Torso = torso;
            }
            else if (jarvis.Torso.EnergyConsumption > torso.EnergyConsumption)
            {
                jarvis.Torso = torso;
            }
        }

        static void ReadHead(List<string> compSpecs, Jarvis jarvis)
        {
            Head head = new Head
            {
                EnergyConsumption = long.Parse(compSpecs[0]),
                IQ = long.Parse(compSpecs[1]),
                SkinMaterial = compSpecs[2]
            };

            if(jarvis.Head == null)
            {
                jarvis.Head = head;
            }
            else if (jarvis.Head.EnergyConsumption > head.EnergyConsumption)
            {
                jarvis.Head = head;
            }
        }
    }
}
