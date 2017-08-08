using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Reverse": ReverseArray(stringArr); break;

                    case "Distinct": stringArr = DistinctArray(stringArr); break;

                    case "Replace":
                        int replaceIndex = int.Parse(command[1]);
                        string replaceString = command[2];

                        try
                        {
                            ReplaceOnIndex(replaceIndex, replaceString, stringArr);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input!");
                        }

                        break;

                    default: Console.WriteLine("Invalid input!"); break;
                }
                command = Console.ReadLine().Split(' ');
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
