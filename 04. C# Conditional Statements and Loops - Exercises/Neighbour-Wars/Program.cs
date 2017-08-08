using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int peshosHealth = 100;
            int goshosHealth = 100;

            for (int i = 1; true; i++)
            {
                if (i % 2 == 0)
                {
                    peshosHealth -= goshosDamage;
                    if (peshosHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                }
                else
                {
                    goshosHealth -= peshosDamage;
                    if (goshosHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                }

                if(i % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }
        }
    }
}
