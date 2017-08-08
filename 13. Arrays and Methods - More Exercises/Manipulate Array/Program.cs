using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ').ToArray();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(' ');

                switch (command[0])
                {
                    case "Reverse": ReverseArray(stringArr); break;
                    case "Distinct": stringArr = DistinctArray(stringArr); break;
                    case "Replace":
                        int replaceIndex = int.Parse(command[1]);
                        string replaceString = command[2];
                        ReplaceOnIndex(replaceIndex, replaceString, stringArr); break;
                }
            }

            Console.WriteLine(String.Join(", ", stringArr));
        }

        static void ReverseArray(string[] arr)
        {
            Array.Reverse(arr);
        }

        static string[] DistinctArray(string[] arr)
        {
            arr = arr.Distinct().ToArray();

            return arr;
        }

        static void ReplaceOnIndex(int index, string replace, string[] arr)
        {
            arr[index] = replace;
        }
    }
}
