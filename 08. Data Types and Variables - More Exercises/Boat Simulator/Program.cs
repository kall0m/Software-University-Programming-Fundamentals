using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            int firstBoatTiles = 0;
            int secondBoatTiles = 0;

            for (int i = 1; i <= n; i++)
            {
                if (firstBoatTiles >= 50)
                {
                    Console.WriteLine(firstBoat);
                    return;
                }
                else if (secondBoatTiles >= 50)
                {
                    Console.WriteLine(secondBoat);
                    return;
                }

                string boatSpeed = Console.ReadLine();

                if(boatSpeed == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }

                if(i % 2 != 0)
                {
                    firstBoatTiles += boatSpeed.Length;
                }
                else
                {
                    secondBoatTiles += boatSpeed.Length;
                }
            }

            if(firstBoatTiles > secondBoatTiles)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
