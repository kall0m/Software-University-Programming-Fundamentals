using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while(command != "end")
            {
                var commandTokens = command.Split();

                if(commandTokens[0] == "exchange")
                {
                    var index = int.Parse(commandTokens[1]);

                    if(index < 0 || index >= nums.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    var subArr1 = nums.GetRange(0, index + 1);
                    var subArr2 = nums.GetRange(index + 1, nums.Count - (index + 1));

                    nums = new List<int>();

                    nums.AddRange(subArr2);
                    nums.AddRange(subArr1);
                }
                else if(commandTokens[0] == "max")
                {
                    if(commandTokens[1] == "even")
                    {
                        var evens = nums.Where(n => n % 2 == 0).ToList();
                        if(evens.Count == 0)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine(nums.LastIndexOf(evens.Max()));
                    }
                    else if(commandTokens[1] == "odd")
                    {
                        var odds = nums.Where(n => n % 2 != 0).ToList();
                        if (odds.Count == 0)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine(nums.LastIndexOf(odds.Max()));
                    }
                }
                else if(commandTokens[0] == "min")
                {
                    if (commandTokens[1] == "even")
                    {
                        var evens = nums.Where(n => n % 2 == 0).ToList();
                        if (evens.Count == 0)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine(nums.LastIndexOf(evens.Min()));
                    }
                    else if (commandTokens[1] == "odd")
                    {
                        var odds = nums.Where(n => n % 2 != 0).ToList();
                        if (odds.Count == 0)
                        {
                            Console.WriteLine("No matches");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine(nums.LastIndexOf(odds.Min()));
                    }
                }
                else if (commandTokens[0] == "first")
                {
                    var count = int.Parse(commandTokens[1]);

                    if (count > nums.Count)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (commandTokens.Last() == "even")
                    {
                        var evens = nums.Where(n => n % 2 == 0).ToList();
                        if (evens.Count == 0)
                        {
                            Console.WriteLine("[]");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", evens.Take(count))}]");
                    }
                    else if (commandTokens.Last() == "odd")
                    {
                        var odds = nums.Where(n => n % 2 != 0).ToList();
                        if (odds.Count == 0)
                        {
                            Console.WriteLine("[]");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", odds.Take(count))}]");
                    }
                }
                else if (commandTokens[0] == "last")
                {
                    var count = int.Parse(commandTokens[1]);

                    if (count > nums.Count)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (commandTokens.Last() == "even")
                    {
                        var evens = nums.Where(n => n % 2 == 0).Reverse().ToList();
                        if (evens.Count == 0)
                        {
                            Console.WriteLine("[]");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", evens.Take(count).Reverse())}]");
                    }
                    else if (commandTokens.Last() == "odd")
                    {
                        var odds = nums.Where(n => n % 2 != 0).Reverse().ToList();
                        if (odds.Count == 0)
                        {
                            Console.WriteLine("[]");
                            command = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"[{string.Join(", ", odds.Take(count).Reverse())}]");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }
    }
}
