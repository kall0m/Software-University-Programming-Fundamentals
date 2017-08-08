using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int mhealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int menergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', health), new string('.', mhealth - health));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energy), new string('.', menergy - energy));
        }
    }
}
