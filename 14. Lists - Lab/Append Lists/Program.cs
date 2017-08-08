using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numsAndSpaces = Console.ReadLine().Split('|').ToList();

            numsAndSpaces.Reverse();

            List<string> results = new List<string>();

            for (int i = 0; i < numsAndSpaces.Count; i++)
            {
                foreach (var num in numsAndSpaces[i].Split(' '))
                {
                    if (num != "")
                    {
                        results.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
