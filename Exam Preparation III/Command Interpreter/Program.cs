using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Where(e => e != "").ToList();

            var command = Console.ReadLine();           

            while (command != "end")
            {
                var commandTokens = command.Split();
                var commandName = commandTokens[0];
                var startIndex = 0;
                var count = 0;          

                var subArray = new List<string>();

                switch (commandName)
                {
                    case "reverse":
                        startIndex = int.Parse(commandTokens[2]);
                        count = int.Parse(commandTokens.Last());

                        if (startIndex < 0 || startIndex >= array.Count || count < 0 || count > array.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine();
                            continue;
                        }

                        subArray = array.GetRange(startIndex, count);

                        subArray.Reverse();

                        for (int i = startIndex, j = 0; i < startIndex + count; i++, j++)
                        {
                            array[i] = subArray[j];
                        }
                        break;
                    case "sort":
                        startIndex = int.Parse(commandTokens[2]);
                        count = int.Parse(commandTokens.Last());

                        if (startIndex < 0 || startIndex >= array.Count || count < 0 || count > array.Count)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine();
                            continue;
                        }

                        subArray = array.GetRange(startIndex, count);

                        subArray.Sort();

                        for (int i = startIndex, j = 0; i < startIndex + count; i++, j++)
                        {
                            array[i] = subArray[j];
                        }
                        break;
                    case "rollLeft":
                        count = int.Parse(commandTokens[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine();
                            continue;
                        }

                        for (int i = 0; i < count; i++)
                        {
                            array.Add(array.First());
                            array.RemoveAt(0);
                        }
                        break;
                    case "rollRight":
                        count = int.Parse(commandTokens[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine();
                            continue;
                        }

                        array.Reverse();

                        for (int i = 0; i < count; i++)
                        {
                            array.Add(array.First());
                            array.RemoveAt(0);
                        }
                        
                        array.Reverse();
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
    }
}
