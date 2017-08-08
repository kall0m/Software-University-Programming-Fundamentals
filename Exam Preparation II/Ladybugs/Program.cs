using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var initalIndexesOfLadybugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine().Split();

            var ladybugsInField = new List<int>();

            for (int i = 0; i < fieldSize; i++)
            {
                if (initalIndexesOfLadybugs.Contains(i))
                {
                    ladybugsInField.Add(1);
                }
                else
                {
                    ladybugsInField.Add(0);
                }
            }

            while(command[0] != "end")
            {
                var ladybugIndex = int.Parse(command[0]);
                var direction = command[1].ToLower();
                var flyLength = int.Parse(command[2]);

                if(!(0 <= ladybugIndex && ladybugIndex < fieldSize))
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if(ladybugsInField[ladybugIndex] == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if(direction == "right")
                {
                    ladybugsInField[ladybugIndex] = 0;

                    var landedIndex = ladybugIndex + flyLength;

                    if(landedIndex > fieldSize - 1)
                    {
                        continue;
                    }

                    var isInField = true;

                    while(ladybugsInField[landedIndex] != 0)
                    {
                        landedIndex += flyLength;

                        if(landedIndex > fieldSize - 1)
                        {
                            isInField = false;
                            break;
                        }
                    }

                    if (isInField)
                    {
                        ladybugsInField[landedIndex] = 1;
                    }
                }
                else if(direction == "left")
                {
                    ladybugsInField[ladybugIndex] = 0;

                    var landedIndex = ladybugIndex - flyLength;

                    if(landedIndex < 0)
                    {
                        continue;
                    }

                    var isInField = true;

                    while(ladybugsInField[landedIndex] != 0)
                    {
                        landedIndex -= flyLength;

                        if(landedIndex < 0)
                        {
                            isInField = false;
                            break;
                        }
                    }

                    if (isInField)
                    {
                        ladybugsInField[landedIndex] = 1;
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladybugsInField));
        }
    }
}
