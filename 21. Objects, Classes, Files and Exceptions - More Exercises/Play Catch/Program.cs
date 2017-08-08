using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var exceptions = 0;

            while(exceptions != 3)
            {
                var command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Replace":
                        try
                        {
                            Replace(array, int.Parse(command[1]), int.Parse(command[2]), ref exceptions);
                        }
                        catch
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptions++;
                        }
                        break;
                    case "Print":
                        try
                        {
                            Print(array, int.Parse(command[1]), int.Parse(command[2]), ref exceptions);
                        }
                        catch
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptions++;
                        }
                        break;
                    case "Show":
                        try
                        {
                            Show(array, int.Parse(command[1]), ref exceptions);
                        }
                        catch
                        {
                            Console.WriteLine("The variable is not in the correct format!");
                            exceptions++;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }

        static void Show(int[] array, int index, ref int exceptions)
        {
            try
            {
                Console.WriteLine(array[index]);
            }
            catch
            {
                Console.WriteLine("The index does not exist!");
                exceptions++;
                return;
            }
        }

        static void Print(int[] array, int startIndex, int endIndex, ref int exceptions)
        {
            var newArray = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                try
                {
                    newArray.Add(array[i]);
                }
                catch
                {
                    Console.WriteLine("The index does not exist!");
                    exceptions++;
                    return;
                }
            }

            Console.WriteLine(string.Join(", ", newArray));
        }

        static void Replace(int[] array, int index, int element, ref int exceptions)
        {
            try
            {
                array[index] = element;
            }
            catch
            {
                Console.WriteLine("The index does not exist!");
                exceptions++;
                return;
            }
        }
    }
}
